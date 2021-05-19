using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderWebCSharp.Models
{
    public class OfferService
    {
        public OfferService()
        {
            Inventory = GetInventory();
        }
        private List<Product> Inventory{ get; set; }

        private List<Product> GetInventory()
        {

            List<Product> listProducts=new List<Product>();

             Product p1 = new Product("P1", 1000, "P1 desc");
            Product p2 = new Product("P1", 200, "P2 desc");
            Product p3 = new Product("P1", 400, "P3 desc"); 
            Product p4 = new Product("P1", 700, "P4 desc");
            Product p5 = new Product("P1", 600, "P5 desc");
            Product p6 = new Product("P1", 800, "P6 desc");

            listProducts.Add(p1);
            listProducts.Add(p2); 
            listProducts.Add(p3); 
            listProducts.Add(p4); 
            listProducts.Add(p5);
            listProducts.Add(p6);

            return listProducts;
        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Product> GetTodaysOffers()
        {
            return null;
        }
    }
}