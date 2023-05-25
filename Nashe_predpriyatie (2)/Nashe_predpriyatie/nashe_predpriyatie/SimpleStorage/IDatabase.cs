using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStorage
{
    public interface IDatabase
    {
        void Add(Product item);
        void Remove (Product item);

        IEnumerable<Product> Find(string name);

        IEnumerable<Product> Find(string name, double priceFrom, double priceTo);

        void Save();

        void Load();

    }
}
