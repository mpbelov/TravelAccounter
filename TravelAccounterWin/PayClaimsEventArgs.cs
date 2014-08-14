using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting.Model;

namespace TravelAccounterWin
{
    public class PayClaimsEventArgs : EventArgs
    {
        public PayClaimsEventArgs()
        {
            this.Claims = new Collection<Claim>();
        }

        public ICollection<Claim> Claims { get; protected set; }
    }
}
