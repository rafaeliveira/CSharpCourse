using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Lists_Employee
{
    class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double dIncrease)
        {
            Salary += Salary * (dIncrease / 100);
        }

        public override string ToString()
        {
            return "\nID: " + Id
                + "\nName: " + Name
                + "\nSalary: R$ " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}