using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStorage
{
    public class Product
    {
        public string Name { get; set; }

        public string ManufacturerName { get; set; }

        public double Price { get; set; }

        public Product() { }    

        public Product(string name, string manufacturerName, double price)
        {
            Name = name;
            ManufacturerName = manufacturerName;
            Price = price;
        }

    }
}
