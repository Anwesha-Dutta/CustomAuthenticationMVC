﻿using CustomAuthenticationinMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static CustomAuthenticationinMVC.Models.AuthorizeRole;

namespace CustomAuthenticationinMVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AuthorizeRole(Role.SUPERADMIN, Role.ADMIN)]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeRole(Role.SUPERADMIN)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AuthorizeRole(Role.ADMIN)]

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AuthorizeRole(Role.USER)]
     public ActionResult UserPage()
        {
            ViewBag.Message = "User Page";
            return View();
        }
    }
}