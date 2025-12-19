using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7._2
{
    internal class Product
    {
        /*Створіть клас Product, який містить інформацію про товар: назву, кількість і ціну.
         * Реалізуйте перевантаження таких операторів:
        + та - для збільшення або зменшення кількості товару.
        ==, != для порівняння товарів за ціною.
        > і < для порівняння товарів за кількістю.
        Використовуйте властивості для управління кількістю та ціною товару.
        Додайте перевірку у властивостях, щоб кількість не могла бути від'ємною.*/

        public string Name { get; set; }

        private int quantity;
        private decimal price;

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity cannot be negative.");
                quantity = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                price = value;
            }
        }

        public Product(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }

        public static Product operator +(Product product, int amount)
        {
            product.Quantity += amount;
            return product;
        }

        public static Product operator -(Product product, int amount)
        {
            product.Quantity -= amount;
            return product;
        }

        public static bool operator ==(Product p1, Product p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Price == p2.Price;
        }

        public static bool operator !=(Product p1, Product p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Product p1, Product p2)
        {
            return p1.Quantity > p2.Quantity;
        }

        public static bool operator <(Product p1, Product p2)
        {
            return p1.Quantity < p2.Quantity;
        }

        public override bool Equals(object obj)
        {
            if (obj is Product other)
                return Name == other.Name && Quantity == other.Quantity && Price == other.Price;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Quantity, Price);
        }

        public override string ToString()
        {
            return $"{Name}: Quantity = {Quantity}, Price = {Price:F2}";
        }

    }
}
