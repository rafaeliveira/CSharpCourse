using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using ContributionFee.Enum;

namespace ContributionFee.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExp { get; set; }

        public Individual(string name, double anualIncome, double healthExp) : base(name, anualIncome)
        {
            HealthExp = healthExp;
        }

        public override double taxPaid()
        {
            double dFee = 0d;
            double dHealthFee = 0d;

            if (AnualIncome < 20000)
            {
                dFee = (int)Fees.Individual_under/100.00;
            }
            else
            {
                dFee = (int)Fees.Individual_above/100.00;
            }

            if(HealthExp > 0)
            {
                dHealthFee = (int)Fees.Individual_Health/100.00;
            }

            return (AnualIncome * dFee) - (HealthExp * dHealthFee);
        }
    }
}