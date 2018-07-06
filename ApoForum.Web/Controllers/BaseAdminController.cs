using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace ApoForum.Web.Controllers
{
    [Authorize]
    public class BaseAdminController : Controller
    {
        private ApplicationUserManager _userManager;

        public BaseAdminController()
        {

        }


        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
           
        }

     

        public string GetUserId
        {
            get
            {
                return User.Identity.GetUserId();
            }
        }
    }
}