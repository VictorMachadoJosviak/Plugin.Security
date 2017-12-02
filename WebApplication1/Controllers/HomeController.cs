using Plugin.Security.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string email,string pwd)
        {
            var hash = new PasswordEncoder();
            var salt = hash.DefaultSalt;

            ViewBag.hash = hash.Encode(salt + email + pwd);

            return View();
        }
    }
}