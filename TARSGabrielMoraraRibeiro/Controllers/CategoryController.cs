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

        public JsonResult ListCategorys()
        {
            try
            {
                var categorys = rep._context.Categorys.ToList();
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
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }

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
                }
                else
                {
                    return Json("Categoria já existe", HttpStatusCode.BadRequest);
                }

                return Json("OK");
            }
            catch (Exception)
            {
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }

        public JsonResult UpdateCategory(string id, string name)
        {
            try
            {
                var category = rep._context.Categorys.FirstOrDefault(s => s.CategoryID == Convert.ToInt32(id));
                category.Name = name;
                rep._context.SaveChanges();
                return Json("OK");
            }
            catch (Exception)
            {
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }


        public JsonResult DeleteCategory(string id, string name)
        {
            try
            {
                var category = rep._context.Categorys.FirstOrDefault(s => s.CategoryID == Convert.ToInt32(id));
                if (category != null)
                {
                    rep._context.Categorys.Remove(category);
                    rep._context.SaveChanges();
                    return Json("OK");
                }
                return Json("Categoria nao existi", HttpStatusCode.BadRequest);
            }
            catch (Exception e)
            {
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }
    }
}
