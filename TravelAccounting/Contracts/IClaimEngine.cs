using System;
using System.Collections.Generic;
using TravelAccounting.Model;

namespace TravelAccounting.Contracts
{
    public interface IClaimEngine
    {
        ICollection<Claim> CalcClaims();
    }
}