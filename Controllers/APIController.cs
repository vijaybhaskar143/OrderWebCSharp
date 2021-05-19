using OrderWebCSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace OrderWebCSharp.Controllers
{
    public class APIController : ApiController
    {
        private OfferService offerService;
        public APIController(OfferService _offerService)
        {
            offerService = _offerService;
        }

        [HttpGet]
        private async Task<List<Product>> RetrieveOffers()
        {
            List<Product> listOffers =  offerService.GetTodaysOffers();
            return listOffers;
        }

        [HttpGet]
        private async Task<List<Product>> RetrieveProducts()
        {
            List<Product> listProducts = offerService.GetAllProducts();
            listProducts.Where(x => x.Price < 1).ToList(); //Logic need to write here
            return null;
        }

        [HttpPost]
        private void CreateProduct()
        {
            Product p = new Product("NewProduct", 8000, "Brand New");
            offerService = new OfferService();
        }

    }
}
