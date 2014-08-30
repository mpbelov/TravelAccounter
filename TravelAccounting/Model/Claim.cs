using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model {
    public class Claim {
        public Claim(Currency currency) {
            this.Currency = currency;
        }
        private Currency currency;

        public virtual Account Creditor { get; set; }
        public virtual Account Debtor { get; set; }

        public virtual Currency Currency {
            get { return currency; }
            set {
                if (value == null)
                    throw new ArgumentNullException("Currency cannot be null");
                this.currency = value;
            }
        }
        public virtual decimal BaseAmount { get { return ActualAmount * Currency.ExchangeRate; } }
        public virtual decimal ActualAmount { get; set; }

        public override string ToString() {
            return string.Format("Claim. {0} takes {1} {2} from {3}", Creditor.Name, ActualAmount, Currency.ShortName, Debtor.Name);
        }
    }
}