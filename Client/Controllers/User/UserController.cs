using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers.User
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var level = HttpContext.Session.GetString("lvl");
            if (level == "Admin")
            {
                return RedirectToAction("Index", "Home");
            }
            else if (level == "User")
            {
                return View("~/Views/User/UserDasbor.cshtml");
            }
            else
            {
                return Redirect("/validate");
            }
        }
    }
}
