﻿using System;
using System.Globalization;
using System.Text;

namespace Polimorfismo02.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.AppendFormat(" $ {0}", Price.ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
