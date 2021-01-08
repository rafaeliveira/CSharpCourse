using System;
using System.Collections.Generic;
using System.Text;
using ContributionFee.Enum;

namespace ContributionFee.Entities
{
    class Company : Taxpayer
    {
        public int EmployeeNum { get; set; }

        public Company(string name, double anualIncome, int employeeNum) : base(name, anualIncome)
        {
            EmployeeNum = employeeNum;
        }

        public override double taxPaid()
        {
            double dFee = 0d;

            if(EmployeeNum > 10)
            {
                dFee = (int) Fees.Company_above/100.00;
            }
            else
            {
                dFee = (int)Fees.Company_under / 100.00;
            }

            return AnualIncome * dFee;
        }
    }
}