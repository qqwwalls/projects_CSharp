using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_hw
{
    internal class Journal
    {
        /*Створіть клас "Журнал". Необхідно зберігати в полях класу:
 * назву журналу, рік заснування, опис журналу, 
 * контактний телефон, контактний email. 
 * Реалізуйте методи класу для введення даних, виведення даних, 
 * реалізуйте доступ до окремих полів через методи класу.*/
        public string title { get; set; } = String.Empty;
        private int year;
        public string description { get; set; } = String.Empty;
        public string contactPhone { get; set; } = String.Empty;
        public string phoneNumber { get; set; } = String.Empty;
        public string contactEmail { get; set; } = String.Empty;
        public Journal(string title, int year, string description, string contactPhone, string phoneNumber, string contactEmail)
        {
            this.title = title;
            this.year = year;
            this.description = description;
            this.contactPhone = contactPhone;
            this.phoneNumber = phoneNumber;
            this.contactEmail = contactEmail;
        }
        public int MyYear
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error. Wrong year data");
                year = value;
            }

        }
        public void show()
        {
            Console.WriteLine($"Name of journal: {title}, {MyYear}  year\nDescription: {description}\nContact phone: {contactPhone}" +
                $"\nPhone number: {phoneNumber}\nContact email: {contactEmail}");
        }
    }
}
