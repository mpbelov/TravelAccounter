using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAccounterWin
{
    public class NameDetailsEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
