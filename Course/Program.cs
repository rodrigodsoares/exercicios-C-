using System;
using Course.Entities.Enums;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Departament's name: ");
            String DeptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data: ");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior) : ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(DeptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many Contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} Contract data: ");
                Console.Write("DD/MM/YYYY : " );
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (Hour): ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContratct(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            String monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for "+ monthAndYear +": " + worker.Income(year, month));

            Console.ReadLine();
        }

        
    }
}
