using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting.Contracts;
using TravelAccounting.Model;

namespace TravelAccounting
{
    public class ClaimEngine : IClaimEngine
    {
        public ClaimEngine(Travel travel)
        {
            this.travel = travel;
        }
        protected Travel travel { get; set; }

        public ICollection<Claim> CalcClaims()
        {
            ICollection<Claim> claims = new Collection<Claim>();

            var debtors = travel.Accounts.Where(a => a.Debt > decimal.Zero).OrderBy(a => a.Debt);
            var creditors = travel.Accounts.Where(a => a.Credit > decimal.Zero).OrderBy(a => a.Credit);
            
            Dictionary<Account, decimal> debts = new Dictionary<Account, decimal>();
            Dictionary<Account, decimal> credits = new Dictionary<Account, decimal>();
            foreach (var c in creditors) credits.Add(c, c.Credit);
            foreach (var d in debtors) debts.Add(d, d.Debt);

            foreach (var c in creditors)
            {
                foreach (var d in debtors)
                {
                    if (credits[c] >= debts[d])
                    {
                        Claim claim = new Claim(travel.BaseCurrency);
                        claim.Creditor = c;
                        claim.Debtor = d;

                        claim.ActualAmount = debts[d];
                        credits[c] = credits[c] - debts[d];
                        debts[d] = 0;
                        claims.Add(claim);
                    }
                    else
                    {
                        Claim claim = new Claim(travel.BaseCurrency);
                        claim.Creditor = c;
                        claim.Debtor = d;

                        claim.ActualAmount = credits[c];
                        credits[c] = 0;
                        debts[d] = debts[d] - credits[c];
                        claims.Add(claim);
                    }
                }
            }

            return claims;
        }
    }
}
