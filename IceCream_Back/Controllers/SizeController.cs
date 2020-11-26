using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bl;
using Dto;

namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/size")]
    public class SizeController : ApiController
    {
        [Route("sizes/{id}")]
        public IHttpActionResult GetSizes(int id)
        {
            List<SizeDto> sizes = SizeBl.GetSizes(id);
            if (sizes != null)
                return Ok(sizes);
            return BadRequest();
        }
    }
}
