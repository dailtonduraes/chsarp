using System;

namespace Polimorfismo02.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return "Name (used) $ " + 
                Price + "(Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
