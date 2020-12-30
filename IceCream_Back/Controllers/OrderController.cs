using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bl;

namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/order")]
    public class OrderController : ApiController
    {
        [HttpPost]
        [Route("order")]
        public IHttpActionResult addOrder([FromBody] OrderDto order)
        {
            bool b = OrderBl.addOrder(order);
            if (b)
                return Ok();
            return BadRequest();
        }
    }
}
