using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;

using SagarautopartContext;
namespace Sagar_Auto_Mobiles_API.Controllers
{
    /// <summary>
    /// Controller for Admin
    /// </summary>
    public class AdminController : ApiController
    {
        [ActionName("Login")]
        [HttpPost]  
        public IHttpActionResult Login([FromBody]Admin admin)
        {
            var dbo = new SagarautopartDataContext();
            var dbAdmin = (from a in dbo.Admins
                        where a.Email == admin.Email && a.Password == admin.Password 
                        select a).FirstOrDefault();

            if(dbAdmin == default(Admin)) {
                return Content(HttpStatusCode.Unauthorized,"Please enter valid credentials"); 
               
            } else {
                return Ok(dbAdmin);
            }
            

        }
    }
}
