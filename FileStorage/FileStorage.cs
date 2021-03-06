﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelAccounting.Contracts;
using TravelAccounting.Model;
using TravelAccounting.Model.Xml;

namespace FileStorage
{
    public class FileStorage : IExternalStorage
    {
        ISerializer serializer = new Serializer();

        public Travel ImportTravel(string externalResource)
        {
            var xDoc = XDocument.Load(externalResource);
            var travel = serializer.Deserialize(xDoc);
            return travel;
        }

        public Travel ImportTravel(Stream stream)
        {
            var xDoc = XDocument.Load(stream);
            var travel = serializer.Deserialize(xDoc);
            return travel;
        }

        public void ExportTravel(Travel travel, string externalResource)
        {
            var xDoc = serializer.Serialize(travel);
            if (File.Exists(externalResource))
                File.Delete(externalResource);
            xDoc.Save(externalResource);
        }

        public Stream ExportTravel(Travel travel)
        {
            var xDoc = serializer.Serialize(travel);

            Stream stream = new MemoryStream();
            xDoc.Save(stream);
            stream.Position = 0;

            return stream;
        }
    }
}