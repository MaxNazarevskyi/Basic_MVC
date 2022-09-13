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
        public List<LoginModel> Users()
        {
            List<LoginModel> users = new List<LoginModel>
            {
                new LoginModel {login ="max", password = "1234", admin = false},
                new LoginModel {login ="max2", password = "12345", admin = true}
            };
            return users;
        }
        public IActionResult Check(LoginModel user)
        {
            user.login = this.Request.Form["login"];
            user.password = this.Request.Form["password"];
            foreach (var record in Users())
            {
                if (user.login == record.login && user.password == record.password)
                {
                    user.admin = record.admin;
                    break;
                }

            }
            if (user.login == null || user.password == null)
            {
                return View("Login");
            }
            return View("Check", user);
        }
    }
}
