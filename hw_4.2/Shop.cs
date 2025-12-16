using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4._2
{
    internal class Shop
    {
        /*Створіть клас "Магазин". Необхідно зберігати в полях класу:
         * назву магазину, адресу, опис профілю магазину, контактний телефон,
         * контактний email. Реалізуйте методи класу для введення даних, виведення даних, 
         * реалізуйте доступ до окремих полів через методи класу.*/
        public string title { get; set; }= String.Empty;
        public string adress { get; set; } = String.Empty;
        public string description { get; set; } = String.Empty;
        public string phone { get; set; } = String.Empty;
        public string email { get; set; } = String.Empty;
        public Shop(string title, string adress, string description, string phone, string email)
        {
            this.title = title;
            this.adress = adress;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }
        public void show()
        {
         Console.WriteLine($"Title: {title}\nAdress: {adress}\nDescription: {description}\nPhone: {phone}\nEmail: {email}");
        }
    }
}
