using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using User_Reg_MVC_Core.Models;

namespace User_Reg_MVC_Core.Controllers
{
    public class UserRegistrationController:Controller
    {
        private readonly ApplicationUserClass _auc;

        public UserRegistrationController(ApplicationUserClass auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserClass uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The User" + uc.UserName + "Is saved successfully..";
            return View();
        }
    }
}
