using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting.Model;

namespace TravelAccounterWin {
    internal class AccountEventArgs : EventArgs {
        public Account Account { get; set; }
    }
}
