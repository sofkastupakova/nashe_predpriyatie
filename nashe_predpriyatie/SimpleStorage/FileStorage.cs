using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SimpleStorage
{
    public class FileStorage : Database
    {
        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
        }

        public FileStorage(string fileName)
        {
            _fileName = fileName;
        }

        public override void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));   
            using (Stream stream = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, _products);
            }
        }

        public override void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
            using (Stream fStream = new FileStream(_fileName, FileMode.Open, FileAccess.Read))
            {
                _products = (List<Product>)xmlSerializer.Deserialize(fStream);
            }
        }
    }
}
