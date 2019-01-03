using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SklepInternetowy.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(User user)
        {
            if(!ModelState.IsValid)
            {
                return View("Register", user);
            }
            else
            {
                return View("Index");
            }
        }
    }
}