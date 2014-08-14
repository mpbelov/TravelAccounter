using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model
{
    public class Claim
    {
        public Account Creditor { get; set; }
        public Account Debtor { get; set; }

        public decimal Amount { get; set; }

        public override string ToString()
        {
            return string.Format("Claim. {0} should take {1} from {2}", Creditor.Name, Amount, Debtor.Name);
        }
    }
}
