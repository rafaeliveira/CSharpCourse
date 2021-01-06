using System;
using System.Collections.Generic;
using System.Globalization;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int iHours = 0;
            int iTotalEmp = 0;

            string sName = "";
            char sOutsourced;

            double dValuePerHour = 0.0;
            double dAdditionalCharge = 0.0;

            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            iTotalEmp = int.Parse(Console.ReadLine());

            if(iTotalEmp > 0)
            {
                for (int i = 0; i < iTotalEmp; i++)
                {
                    Console.WriteLine($"Employee #{i+1} data: ");

                    Console.WriteLine("Outsourced (y/n): ");
                    sOutsourced = char.Parse(Console.ReadLine());

                    Console.WriteLine("Employee Name: ");
                    sName = Console.ReadLine();

                    Console.WriteLine("Hours worked: ");
                    iHours = int.Parse(Console.ReadLine());

                    Console.WriteLine("Value per Hour: ");
                    dValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (sOutsourced == 'y')
                    {
                        Console.WriteLine("Additional Charge: ");
                        dAdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new OutsourceEmployee(sName, iHours, dValuePerHour, dAdditionalCharge));
                    }
                    else
                    {
                        list.Add(new Employee(sName, iHours, dValuePerHour));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                Console.WriteLine();

                foreach(Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $" + emp.payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}