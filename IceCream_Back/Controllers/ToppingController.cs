using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bl;


namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/topping")]
    public class ToppingController : ApiController
    {
        [HttpGet]
        [Route("toppings/{id}")]
        public IHttpActionResult GetToppingsByCatgId(int id)
        {
            var toppings = ToppingBl.GetToppingsById(id);
            if (toppings != null)
                return Ok(toppings);
            else
                return BadRequest();
        }
        [HttpGet]
        [Route("toppingsByCatgProduct/{id}")]
        public IHttpActionResult GetToppingsForCatgProduct(int id)
        {
            var toppings = ToppingBl.GetToppingsForCatgProduct(id);
            if (toppings != null)
                return Ok(toppings);
            else
                return BadRequest();
        }
    }
}
