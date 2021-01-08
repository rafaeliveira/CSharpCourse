using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PriceTag.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double totalPrice()
        {
            return Price + CustomFee;
        }

        public override string priceTag()
        {
            return Name + " $" + totalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Custom Fee: $" + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}