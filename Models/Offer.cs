using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderWebCSharp.Models
{
    public class Offer
    {
        public Offer(string offerName, List<Product> lstProducts)
        {
            OfferName = OfferName;
            ProductList = lstProducts;
        }

        public string OfferName{ get; set; }
        public List<Product> ProductList { get; set; }
    }
}