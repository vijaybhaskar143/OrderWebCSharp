using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderWebCSharp.Models
{
    public class Product
    {
        public Product(string pName, decimal price, string desc)
        {
            ProductName = pName;
            Price = price;
            Description = desc;
        }
        public string ProductName { get; set; }

        public decimal Price{ get; set; }

        public string Description { get; set; }
    }
}