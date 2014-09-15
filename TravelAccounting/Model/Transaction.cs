using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model {
    public class Transaction {
        public Transaction(Travel travel) {
            this.Travel = travel;
            Date = DateTime.Now.Date;
            Currency = new Currency(travel.BaseCurrency);
        }

        public virtual Travel Travel { get; protected set; }
        public virtual string Details { get; set; }
        public virtual Currency Currency { get; set; }

        public virtual DateTime Date { get; set; }

        public override string ToString() {
            return Details;
        }
    }
}