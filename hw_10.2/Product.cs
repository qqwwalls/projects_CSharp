using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10._2
{
    public class Product<T>
    {
        public T Type { get; }
        public string Name { get; }
        public decimal Price { get; }
        public DateTime DateAdded { get; }

        public Product(T type, string name, decimal price, DateTime dateAdded)
        {
            Type = type;
            Name = name;
            Price = price;
            DateAdded = dateAdded;
        }

        public override string ToString()
        {
            return $"{Name} ({Type}), Price: {Price}, Added: {DateAdded:d}";
        }
    }
}
