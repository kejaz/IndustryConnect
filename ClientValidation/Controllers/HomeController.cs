using SampleTestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleTestApp.Controllers
{
    public class HomeController : Controller
    {
        public static List<User> userList = new List<Models.User>();
        public ActionResult Index()
        {
            return View(userList);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (userList.Any(u => u.Name == user.Name))
            {
                ModelState.AddModelError("Name", "User name already in use");
            }

            if (ModelState.IsValid)
            {
                userList.Add(user);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", user);
            }            
        }
        public JsonResult IsNameExist(string name)
        {
              return Json(!userList.Any(user => user.Name == name),JsonRequestBehavior.AllowGet);    
        }   
    }
}