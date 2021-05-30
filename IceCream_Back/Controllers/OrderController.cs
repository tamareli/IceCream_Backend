using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bl;
using System.Security.Claims;


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

        [Authorize]
        [HttpGet]
        [Route("orders")]
        public IHttpActionResult getOrders()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            List<OrderDto> orders = new List<OrderDto>();
            orders = OrderBl.getOrders(Convert.ToInt32(userId));
            if (orders != null)
                return Ok(orders);
            return BadRequest();
        }
    }  
}
