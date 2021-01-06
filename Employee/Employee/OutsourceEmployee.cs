using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {

        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment() + (AdditionalCharge*1.1);
        }
    }
}
