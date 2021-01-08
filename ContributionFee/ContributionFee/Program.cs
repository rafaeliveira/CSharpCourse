using ContributionFee.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ContributionFee
{
    class Program
    {
        static void Main(string[] args)
        {
            int iTPNum = 0;
            int iEmpNum = 0;

            double dAnualIncome = 0d;
            double dHealthExp = 0d;
            double dSum = 0d;

            string sName = "";

            char cType;

            List<Taxpayer> list = new List<Taxpayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            iTPNum = int.Parse(Console.ReadLine());

            if(iTPNum > 0)
            {
                for (int i = 1; i <= iTPNum; i++)
                {
                    Console.WriteLine("Individual or Company (i/c)? ");
                    cType = char.Parse(Console.ReadLine());

                    Console.WriteLine("Name: ");
                    sName = Console.ReadLine();

                    Console.WriteLine("Anual Income: ");
                    dAnualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if(cType == 'i')
                    {
                        Console.WriteLine("Health Expenditures: ");
                        dHealthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new Individual(sName, dAnualIncome, dHealthExp));
                    }
                    else
                    {
                        Console.WriteLine("Number of Employees: ");
                        iEmpNum = int.Parse(Console.ReadLine());

                        list.Add(new Company(sName, dAnualIncome, iEmpNum));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("TAXES PAID");

                foreach (Taxpayer tax in list)
                {
                    Console.WriteLine(tax.Name + ": $" + tax.taxPaid().ToString("F2"), CultureInfo.InvariantCulture);

                    dSum += tax.taxPaid();
                }

                Console.WriteLine("TOTAL TAXES: $" + dSum.ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}