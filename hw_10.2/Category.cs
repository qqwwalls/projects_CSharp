using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10._2
{
    public class Category<T> : IEnumerable<Product<T>>
    {
        private List<Product<T>> products = new List<Product<T>>();

        public void Add(Product<T> product)
        {
            products.Add(product);
        }
        public IEnumerator<Product<T>> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerable<Product<T>> GetByPriceRange(decimal min, decimal max)
        {
            foreach (var product in products)
            {
                if (product.Price >= min && product.Price <= max)
                {
                    yield return product;
                }
            }
        }
        public IEnumerable<Product<T>> GetAddedInLastDays(int days)
        {
            DateTime fromDate = DateTime.Now.AddDays(-days);

            foreach (var product in products)
            {
                if (product.DateAdded >= fromDate)
                {
                    yield return product;
                }
            }
        }
    }
}
