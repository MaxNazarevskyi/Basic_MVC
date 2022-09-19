using Basic_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Basic_MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
        public IActionResult Info(LoginModel user)
        {
            return RedirectToAction("Index", "Check", user);
        }
    }
}
