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

        public IActionResult EditProduct()
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
                return new JsonResult("Houve um erro interno, já estamos verificando.")
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
            }
        }

        public JsonResult UpdateProduct(string productID, string data)
        {
            try
            {
                if (productID != null && data != null)
                {
                    var product = rep._context.Products.FirstOrDefault(s => s.ProductID == Convert.ToInt64(productID));
                    var newProduct = JsonConvert.DeserializeObject<Products>(data);

                    product.Title = newProduct.Title;
                    product.Brand = newProduct.Brand;
                    product.Description = newProduct.Description;
                    product.Stock = newProduct.Stock;
                    product.PriceDefault = newProduct.PriceDefault;
                    product.PriceOffer = newProduct.PriceOffer;
                    product.ean = newProduct.ean;
                    product.ncm = newProduct.ncm;
                    product.Warranty = newProduct.Warranty;
                    product.Height = newProduct.Height;
                    product.Lenght = newProduct.Lenght;
                    product.Width = newProduct.Width;
                    product.Weight = newProduct.Weight;
                    product.CategoryID = newProduct.CategoryID;
                    product.Updated_at = Common.Commons.HourBrasilia;

                    rep._context.SaveChanges();

                    return Json("OK");
                }

                return new JsonResult("Requisição mal formada.")
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
            catch (Exception e)
            {
                return new JsonResult("Houve um erro interno, já estamos verificando.")
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
            }
        }

        public JsonResult GetProductByID(string productID)
        {
            try
            {
                var product = rep._context.Products.FirstOrDefault(s => s.ProductID == Convert.ToInt64(productID));
                return Json(product);
            }
            catch (Exception e)
            {
                return new JsonResult("Houve um erro interno, já estamos verificando.")
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError
                };
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
