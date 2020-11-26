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
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public IHttpActionResult Register([FromBody] UserDto user)
        {
            bool b = UserBl.Register(user);
            if (b)
                return Ok();
            return BadRequest();
        }
    }
}
