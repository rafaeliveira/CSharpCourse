﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PriceTag.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + " (used) $" + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}