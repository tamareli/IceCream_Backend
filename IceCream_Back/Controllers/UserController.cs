using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dto;
using Bl;
using System.Web;
using System.Security.Claims;


namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("register")]
        public IHttpActionResult Register([FromBody] UserDto user)
        {
            if (ModelState.IsValid)
            {
                int userId = UserBl.Register(user);
                if (userId!=0)
                    return Ok(userId);
                return BadRequest("אימייל קיים כבר במערכת");
            }
            else
            {
                return BadRequest("נא מלא את הפרטים ללא שגיאות");
            }

        }
        [HttpPost]
        [Route("addGuestUser")]
        public IHttpActionResult AddGuestUser([FromBody] UserDto user)
        {
            if (ModelState.IsValid)
            {
                int userId = UserBl.AddGuestUser(user);
                if (userId != 0)
                    return Ok(userId);
                return BadRequest();
            }
            else
            {
                return BadRequest("נא מלא את הפרטים ללא שגיאות");
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetUser")]
        public IHttpActionResult GetUser()
        {
            var identity = (ClaimsIdentity)User.Identity;
            var userId = identity.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = UserBl.GetUser(Convert.ToInt32(userId));
            if(user!= null)
                return Ok(user);
            return BadRequest();
        }


    }
}
