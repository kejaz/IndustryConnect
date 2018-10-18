using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FormAuthentication.Controllers
{
    public class SecurityController : Controller
    {
        //public IPrincipal Principal { get; set; }
        public ActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckUser(FormCollection frm)
        {
            // if((frm["txtUserId"].ToString() == "01") &&  (frm["frmPassword"].ToString() =="01"))
            if(Request.Form["txtUserId"] == "01" && Request.Form["txtPassword"] == "01")
            {
                //var identity = new GenericIdentity(Request.Form["txtUserId"]);
                //this.Principal = new GenericPrincipal(identity, new string[] { "Admin"});
                //Thread.CurrentPrincipal = this.Principal;
                //HttpContext.User.Identity = this.Principal;
                FormsAuthentication.SetAuthCookie(Request.Form["txtUserId"], true);
                //FormsAuthentication.
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Security");
        }
    }
}