using Basic_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_MVC.Controllers
{
    public class CheckController : Controller
    {
        public IActionResult Index(LoginModel user)
        {
            user.passCorrect = false;
            foreach (var record in Users())
            {
                if (user.login == record.login && user.password == record.password)
                {
                    user.passCorrect = true;
                    user.admin = record.admin;
                    return View("Check", user);
                }
            }
            if (user.login == null || user.password == null)
            {
                return RedirectToAction("Index","Login");
            }
            return View("Check", user);
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
    }
}
