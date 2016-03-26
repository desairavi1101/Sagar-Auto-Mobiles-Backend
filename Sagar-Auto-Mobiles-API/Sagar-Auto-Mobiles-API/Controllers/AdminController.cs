using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sagar_Auto_Mobiles_API.Controllers
{
    /// <summary>
    /// Controller for Admin
    /// </summary>
    public class AdminController : ApiController
    {
        [ActionName("Login")]
        [HttpPost]  
        public IHttpActionResult Login()
        {
            return null;
        }
    }
}
