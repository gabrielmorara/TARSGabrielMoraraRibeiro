using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataBaseTars.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TARSGabrielMoraraRibeiro.Models;
using System.Web;
using System.Net;
using DataBaseTars;
using Microsoft.EntityFrameworkCore;
using RestSharp;

namespace TARSGabrielMoraraRibeiro.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return RedirectToAction("ListProducts", "Products");
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }

        public IActionResult Perfil()
        {
            return ValidateUser();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
