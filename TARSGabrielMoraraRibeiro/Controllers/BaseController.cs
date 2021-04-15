using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseTars;
using Microsoft.AspNetCore.Mvc;

namespace TARSGabrielMoraraRibeiro.Controllers
{
    public class BaseController : Controller
    {
        public static RepositoryDB rep = new RepositoryDB();

        public ActionResult ValidateUser()
        {
            var userCPF = HttpContext.Request.Cookies["UserCPF"];
            var userToken = HttpContext.Request.Cookies["UserToken"];

            var validUser = rep.ValidateUser(userCPF, userToken);
            if (validUser)
            {
                return View();
            }

            return View("home/login");
        }
    }
}
