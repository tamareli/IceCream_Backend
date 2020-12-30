using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bl;

namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/deliveryTypes")]
    public class DeliveryTypesController : ApiController
    {
        [HttpGet]
        [Route("types")]
        public IHttpActionResult GetDeliveryTypes()
        {
            var delTypes = DeliveryTypesBl.GetDeliveryTypes();
            if (delTypes != null)
                return Ok(delTypes);
            else
                return BadRequest();
        }
    }
}
