﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormAuthentication.Controllers
{
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.UserName = User.Identity.Name;
            return View();
        }
        //[Authorize]
        public ActionResult Secure()
        {
            ViewBag.UserName = User.Identity.Name;
            return View();
        }
    }
}