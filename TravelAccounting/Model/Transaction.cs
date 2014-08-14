using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounting.Model
{
    public class Transaction
    {
        public Transaction(Travel travel)
        {
            this.Travel = travel;
            Date = DateTime.UtcNow;
        }

        public Travel Travel { get; protected set; }
        public string Details { get; set; }

        public DateTime Date { get; protected set; }

        public override string ToString()
        {
            return Details;
        }
    }
}