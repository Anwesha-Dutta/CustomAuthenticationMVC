using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomAuthenticationinMVC.Models;
using CustomAuthenticationinMVC.DAL;
 using System.Web.Security;

namespace CustomAuthenticationinMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if(model.UserName != null)
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                Repository repo = new Repository();
                USER user = repo.GetUserDetails(model.UserName, model.Password);

                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.UserName, model.RememberMe);
                    FormsAuthentication.SetAuthCookie(Convert.ToString(user.UserID), model.RememberMe);
                    var authTicket = new FormsAuthenticationTicket(1, user.UserName, DateTime.Now, DateTime.Now.AddMinutes(20), false,
                    user.Roles);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    HttpContext.Response.Cookies.Add(authCookie);
                    //Based on the Role we can transfer the user to different page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                    return View(model);
                }
            }
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
       
    }
