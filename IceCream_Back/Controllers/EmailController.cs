using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using Dto;
using Bl;


namespace IceCream_Back.Controllers
{
    [RoutePrefix("api/email")]
    public class EmailController : ApiController
    {
        [HttpPost]
        [Route("sendEmail")]
        public IHttpActionResult SendEmail([FromBody] EmailDto emailObj)
        {
            try
            {
                var fromAddress = new MailAddress("dreamcreamshop@gmail.com", "Dream Cream Team");
                var toAddress = new MailAddress(emailObj.emailAddress, "To User");
                string fromPassword = "dreamcream21";
                string subject = emailObj.subject;
                string body = emailObj.body;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage("dreamcreamshop@gmail.com", emailObj.emailAddress, subject,body))
                {
                    message.IsBodyHtml = true;
                    smtp.Send(message);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("forgotPassword")]
        public IHttpActionResult GetPassword( [FromBody] EmailDto email)
        {
            string password = UserBl.GetPasswordByemail(email.emailAddress);
            if(password != null)
            {
                try
                {
                    var fromAddress = new MailAddress("dreamcreamshop@gmail.com", "Dream Cream Team");
                    var toAddress = new MailAddress(email.emailAddress, "To User");
                    string fromPassword = "dreamcream21";
                    string subject = "שחזור סיסמה";
                    string body = "<p>סיסמתך היא: "+password+"</p>";

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage("dreamcreamshop@gmail.com", email.emailAddress, subject, body))
                    {
                        message.IsBodyHtml = true;
                        smtp.Send(message);
                    }
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest("ישנה תקלה, נסה שוב בעוד כמה דקות");
                }
            }
            return BadRequest("אימייל אינו קיים במערכת");
        }
           
    }
}
