using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model {
    public class Currency {
        public Currency() { }
        public Currency(string name) {
            this.Name = name;
        }
        public Currency(string name, string shortName)
            : this(name) {
            this.ShortName = shortName;
        }

        public Currency(Currency c) {
            this.Name = c.Name;
            this.ShortName = c.ShortName;
            this.ExchangeRate = c.ExchangeRate;
        }

        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }

        public virtual decimal ExchangeRate { get; set; }

        public class BaseCurrency : Currency {

            public BaseCurrency()
                : base(string.Empty) {
            }

            public override decimal ExchangeRate {
                get {return 1M;}
                set {
                    if (value != 1M)
                        throw new InvalidOperationException("Exchange rate for base currency can be only 1");
                    base.ExchangeRate = 1M;
                }
            }
        }
    }
}
