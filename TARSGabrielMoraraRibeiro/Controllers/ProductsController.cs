using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TARSGabrielMoraraRibeiro.Controllers
{
    public class ProductsController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewProduct()
        {
            return ValidateUser();
        }

        public JsonResult GetBrands()
        {
            try
            {
                var brands = rep._context.Products.Select(s => s.Brand).ToList();
                return Json(brands);
            }
            catch (Exception e)
            {
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }
    }
}
