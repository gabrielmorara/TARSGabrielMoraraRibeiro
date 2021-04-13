using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataBaseTars.DataBase;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        public JsonResult CreatedProduct(string data)
        {
            try
            {
                var newProduct = JsonConvert.DeserializeObject<Products>(data);
                rep._context.Products.Add(newProduct);
                rep._context.SaveChanges();

                return Json("OK");
            }
            catch (Exception e)
            {
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }
    }
}
