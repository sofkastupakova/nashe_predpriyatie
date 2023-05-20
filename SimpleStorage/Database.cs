using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStorage
{
    public abstract class Database : IDatabase
    {

        protected List<Product> _products;

        public Database()
        {
            _products = new List<Product>();
        }


        public void Add(Product item)
        {
            _products.Add(item);
            Save();
        }

        public void Remove(Product item)
        {
            _products.Remove(item);
            Save();
        }

        /// <summary>
        /// Поиск товара по наименованию
        /// </summary>
        /// <param name="name">Наименование товара</param>
        /// <returns>Результат поиска</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Product> Find(string name)
        {
            return name != null && name.Length > 0 ? _products.Where(product =>
                name != null &&
                name.Length >= 3 &&
                product.Name.ToLower().Contains(name.ToLower())).ToList() : _products;
        }

        /// <summary>
        /// Поиск товара по наименованию и цене
        /// </summary>
        /// <param name="name">Наименование товара</param>
        /// <param name="priceFrom">Минимальная цена</param>
        /// <param name="priceTo">Максимальная цена</param>
        /// <returns>Результат поиска</returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Product> Find(string name, double priceFrom, double priceTo)
        {
            return _products.Where(product =>
                name != null &&
                name.Length >= 3 &&
                product.Name.ToLower().Contains(name.ToLower()) &&
                product.Price >= priceFrom &&
                product.Price <= priceTo).ToList();
        }

        public abstract void Load();


        public abstract void Save();
    }
}
