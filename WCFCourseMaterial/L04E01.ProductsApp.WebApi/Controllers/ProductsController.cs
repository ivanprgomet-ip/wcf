using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using L04E01.ProductsApp.WebApi.Models;

namespace L04E01.ProductsApp.WebApi.Controllers
{
    /// <summary>
    /// we have a working web api.
    /// every method here can be requested and 
    /// retrieved with the following URI's:
    /// Controller Method:          URI:
    /// GetAllProducts              /api/products
    /// GetProduct                  /api/products/(id)
    /// </summary>
    public class ProductsController : ApiController
    {
        public Product[] products = new Product[]
        {
            new Product() {Id=1,Name="Tomato-Soup",Category="Groceries",Price=1 },
            new Product() {Id=2,Name="Yo-yo",Category="Toys",Price=3.75m },
            new Product() {Id=3,Name="Hammer",Category="Hardware",Price=16.99m },
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var result = products.FirstOrDefault((p => p.Id == id));

            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }
    }
}
