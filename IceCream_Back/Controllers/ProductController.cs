using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bl;

namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("products/{id}")]
        public IHttpActionResult GetProductsByCatgId(int id)
        {
            var products = ProductBl.GetProducts(id);
            if (products != null)
                return Ok(products);
            else
                return BadRequest();
        }
        [HttpGet]
        [Route("product/{id}")]
        public IHttpActionResult GetProductById(int id)
        {
            var product = ProductBl.GetProduct(id);
            if (product != null)
                return Ok(product);
            else
                return BadRequest();
        }
    }
}
