using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public List<string> names = new List<string>() { "David","Chris","Jhon"};

        public ActionResult ModelView()
        {
            return View(names);
        }



        public ActionResult Home()
        {
            return View();
        }
        public string Index()
        {
            return "Hello from ASP.NET MVC";
        }
        //public string Index1(string id)
        //{
        //    return "Hello from ASP.NET MVC," + " ID = " + id;
        //}
        //public string Index2(string id)
        //{
        //    return "Hello from ASP.NET MVC," + " ID = " + id + ", Name = " + Request.QueryString["name"];
        //}
        //public string Index3(string id, string name)
        //{
        //    return "Hello from ASP.NET MVC," + " ID = " + id + ", Name = " + name;
        //}
        //public string Index4(int year, int month)
        //{
        //    return "Hello from ASP.NET MVC," + " Year = " + year + ", Month = " + month;
        //}

        public ActionResult ViewBagView()
        {
            ViewBag.Names = names;
            return View();
        }
        public ActionResult ViewDataView()
        {
            ViewData["names"] = names;
            return View();
        }
        

    }
}