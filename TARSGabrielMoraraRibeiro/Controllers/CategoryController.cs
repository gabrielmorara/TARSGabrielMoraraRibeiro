using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataBaseTars.DataBase;
using Microsoft.AspNetCore.Mvc;
using TARSGabrielMoraraRibeiro.Models;

namespace TARSGabrielMoraraRibeiro.Controllers
{
    public class CategoryController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            return ValidateUser();
        }

        [HttpGet]
        public JsonResult ListCategorys()
        {
            try
            {
                var categorys = rep._context.Categorys.OrderByDescending(s => s.CategoryID).ToList();
                var view = new List<CategoriaViewModel>();
                foreach (var item in categorys)
                {
                    var category = new CategoriaViewModel();
                    category.CategoryID = item.CategoryID;
                    category.Name = item.Name;
                    category.QtdProducts = rep._context.Products.Where(s => s.CategoryID == item.CategoryID).Count();

                    view.Add(category);
                }

                return Json(view);
            }
            catch (Exception e)
            {
                return new JsonResult("Houve um erro interno, já estamos verificando.")
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
        }

        [HttpPost]
        public JsonResult CreatedCategory(string name)
        {
            try
            {
                var userCPF = HttpContext.Request.Cookies["UserCPF"];
                var categoryExist = rep._context.Categorys.FirstOrDefault(s => s.Name.Equals(name));
                if (categoryExist == null)
                {
                    var category = new Categorys();
                    category.Name = name;
                    category.Created_at = Common.Commons.HourBrasilia;
                    category.UserID = rep.GetUserByCPF(userCPF).UserID;

                    rep._context.Categorys.Add(category);
                    rep._context.SaveChanges();
                    return Json(category);
                }
                else
                {
                    return new JsonResult("Categoria já existe.")
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }
            }
            catch (Exception)
            {
                return new JsonResult("Houve um erro interno, já estamos verificando.")
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
        }

        [HttpPut]
        public JsonResult UpdateCategory(string categoryID, string name)
        {
            try
            {
                var category = rep._context.Categorys.FirstOrDefault(s => s.CategoryID == Convert.ToInt32(categoryID));

                var categoryExist = rep._context.Categorys.FirstOrDefault(s => s.Name.Equals(name));
                if (categoryExist == null)
                {
                    category.Name = name;
                    category.Updated_at = Common.Commons.HourBrasilia;

                    rep._context.SaveChanges();
                    return Json("OK");
                }
                else
                {
                    return new JsonResult("Categoria já existe, por favor informar um nome diferente.")
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }
            }
            catch (Exception)
            {
                return new JsonResult("Houve um erro interno, já estamos verificando.")
                {
                    StatusCode = (int)HttpStatusCode.BadRequest
                };
            }
        }

        [HttpDelete]
        public JsonResult DeleteCategory(string categoryID)
        {
            try
            {
                var category = rep._context.Categorys.FirstOrDefault(s => s.CategoryID == Convert.ToInt32(categoryID));
                if (category != null)
                {
                    rep._context.Categorys.Remove(category);
                    rep._context.SaveChanges();
                    return Json("OK");
                }

                return new JsonResult("Categoria nao existi.")
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
    }
}
