using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_6
{

    internal class Employee
    {
        public string MyName { get; set; } = String.Empty;
        private int age;
        private int salary;

        public Employee(string name, int age, int salary)
        {
            this.MyName = name;
            this.MyAge = age;
            this.MySalary = salary;
        }

        public int MyAge
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentException("Error. Wrong age");
                age = value;
            }

        }
        public int MySalary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Error. Wrong salary");
                salary = value;
            }
        }
        public void show()
        {
            Console.WriteLine("Name: " + MyName + ", Age: " + MyAge + ", Salary: " + MySalary);
        }
        // перевантаження операторів
        public static Employee operator +(Employee emp, int value)
        {
            emp.MySalary += value;
            return emp;
        }

        public static Employee operator -(Employee emp, int value)
        {
            emp.MySalary -= value;
            return emp;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.MySalary == emp2.MySalary;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.MySalary != emp2.MySalary;
        }

        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.MySalary > emp2.MySalary;
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.MySalary < emp2.MySalary;
        }
        // додаткове перевизначення
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
                return this.MySalary == emp.MySalary;
            return false;
        }

        public override int GetHashCode()
        {
            return MySalary.GetHashCode();
        }
    }

    }
