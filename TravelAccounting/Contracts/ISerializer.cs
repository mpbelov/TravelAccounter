using System;
using System.Xml.Linq;
using TravelAccounting.Model;

namespace TravelAccounting.Contracts {
    public interface ISerializer {
        
        Travel Deserialize(XDocument xDoc);
        
        XDocument Serialize(Travel travel);
    }
}