using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAccounting.Model;

namespace TravelAccounting.Contracts
{
    public interface IExternalStorage
    {
        Travel ImportTravel(string externalResource);

        Travel ImportTravel(Stream stream);

        void ExportTravel(Travel travel, string externalResource);

        Stream ExportTravel(Travel travel);
    }
}
