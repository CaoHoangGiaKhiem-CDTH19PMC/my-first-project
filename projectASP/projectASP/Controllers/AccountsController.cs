using Microsoft.AspNetCore.Mvc;
using projectASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectASP.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            List<Account> lstAccounts = new List<Account>();
            lstAccounts.Add(new Account
            {
                Id = 1,

                Username = "admin",
                Password = "admin",
                Email = "admin@Eshop.com.vn",
                Phone = "01234567890",
                Address = "Tp.Hồ Chí Minh",
                FullName = "Nguyễn Văn Ad Min",
                Avatar = "",
                IsAdmin = true,
                Status = true
            });
            lstAccounts.Add(new Account
            {
                Id = 2,

                Username = "admin2",
                Password = "admin2",
                Email = "admin2@Eshop.com.vn",
                Phone = "01234567892",
                Address = "Tp.Hồ Chí Minh",
                FullName = "Nguyễn Văn Assmin",
                Avatar = "",
                IsAdmin = true,
                Status = true
            });
            //ViewBag.LstAccounts = lstAccounts;
            return View(lstAccounts);
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
