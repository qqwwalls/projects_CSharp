namespace hw_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Додайте до вже створеного класу інформацію про заробітну плату співробітника. 
             Виконайте перевантаження + (для збільшення зарплати на зазначену величину), 
              - (для зменшення зарплати на зазначену величину), 
             == (перевірка на рівність зарплат працівників), 
             != ,Порівняйте заробітні платні двох спіробітників empl1>empl2 та empl1<empl2
             Використовуйте механізм властивостей для полів класу.*/
            Employee worker1 = new Employee("Oskar", 23, 5000);
            worker1.show();
            Employee worker2 = new Employee("Nina", 28, 7000);
            worker2.show();
            worker1 = worker1 + 600;   
            worker2 = worker2 - 1200;    

            Console.WriteLine(worker1 > worker2); 
            Console.WriteLine(worker1 < worker2); 
            Console.WriteLine(worker1 == worker2); 
            Console.WriteLine(worker1 != worker2); 
        }
    }
}
