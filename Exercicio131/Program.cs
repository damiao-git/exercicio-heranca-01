using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio131.Entities;

namespace Exercicio131
    {
    class Program
        {
        static void Main(string[] args)
            {

            List<Employee> emp = new List<Employee>();

            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                {
                Console.WriteLine($"Employee # {i} data: ");
                Console.Write("Outsourced?(y/n)");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y')
                    {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                    }
                else
                    {
                    emp.Add(new Employee(name, hours, valuePerHour));
                    }

                }
            Console.WriteLine();
            Console.Write("Payments: ");
            Console.WriteLine();

            foreach (Employee em in emp)
                {
                Console.WriteLine(em);
                }
            }
        }
    }
