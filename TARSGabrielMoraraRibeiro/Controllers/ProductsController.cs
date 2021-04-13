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

        public IActionResult ListProducts()
        {
            return ValidateUser();
        }

        public JsonResult CreatedProduct(string data)
        {
            try
            {
                var userCPF = HttpContext.Request.Cookies["UserCPF"];
                var user = rep.GetUserByCPF(userCPF);

                var newProduct = JsonConvert.DeserializeObject<Products>(data);
                newProduct.UserID = user.UserID;

                rep._context.Products.Add(newProduct);
                rep._context.SaveChanges();

                return Json("OK");
            }
            catch (Exception e)
            {
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }

        public JsonResult GetProducts()
        {
            try
            {
                var products = rep._context.Products.ToList();
                return Json(products);
            }
            catch (Exception e)
            {
                return new JsonResult("Houve um erro interno, já estamos verificando.")
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
            }
        }
    }
}
