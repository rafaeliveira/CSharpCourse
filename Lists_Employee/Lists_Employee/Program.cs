using System;
using System.Globalization;
using System.Collections.Generic;

namespace Lists_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            int iIdEmp = 0;
            int iNumReg = 0;
            int iIndex = 0;

            string sNameEmp = "";

            double dSalaryEmp = 0d;
            double dIncrease = 0d;

            List<Employees> emp = new List<Employees>();

            Console.WriteLine("***** Employee Register *****");

            Console.Write("How many employees will be registered? ");
            iNumReg = int.Parse(Console.ReadLine());

            if(iNumReg > 0)
            {
                for (int i = 0; i < iNumReg; i++)
                {
                    Console.Write("What employee's ID? ");
                    iIdEmp = int.Parse(Console.ReadLine());

                    Console.Write("What employee's Name? ");
                    sNameEmp = Console.ReadLine();

                    Console.Write("What employee's Salary? ");
                    dSalaryEmp = double.Parse(Console.ReadLine());

                    emp.Add(new Employees { Id = iIdEmp, Name = sNameEmp, Salary = dSalaryEmp });
                }

                Console.WriteLine();
                Console.Write("Enter the employee ID that will have salary increase: ");
                iIdEmp = int.Parse(Console.ReadLine());

                iIndex = emp.FindIndex(x => x.Id == iIdEmp);

                if (iIndex >= 0)
                {
                    Console.WriteLine();
                    Console.Write("Enter the percentage: ");
                    dIncrease = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    emp[iIndex].IncreaseSalary(dIncrease);
                }

                Console.WriteLine("Updated list of employees:");

                foreach (Employees item in emp)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
