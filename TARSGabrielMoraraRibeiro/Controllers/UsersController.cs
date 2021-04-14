using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DataBaseTars;
using DataBaseTars.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace TARSGabrielMoraraRibeiro.Controllers
{
    public class UsersController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AuthenticateUser(string cpf, string password)
        {
            try
            {
                if (cpf == null || password == null)
                {
                    return new JsonResult("Informe o CPF e a senha.")
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }

                var isUser = rep.GetUserByCPF(cpf);

                if (isUser != null)
                {
                    var passswordEncrypt = Common.ConvertedPassword.Encrypt(password);

                    if (isUser.Password_hash.Equals(passswordEncrypt))
                    {
                        return Json(passswordEncrypt);
                    }

                    return new JsonResult("CPF ou senha invalida.")
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }

                return new JsonResult("Usuário não encontrado, crie uma conta para continuar.")
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

        [HttpPost]
        public JsonResult RegisterUser(string name, string email, string cpf, string password)
        {
            try
            {
                var isUserExist = rep.GetUserByCPF(cpf);

                if (isUserExist == null)
                {
                    var passswordEncrypt = Common.ConvertedPassword.Encrypt(password);

                    var newUser = new Users
                    {
                        Name = name,
                        Cpf = String.Join("", System.Text.RegularExpressions.Regex.Split(cpf, @"[^\d]")),
                        Email = email,
                        Password_hash = passswordEncrypt,
                        Created_at = Common.Commons.HourBrasilia
                    };

                    rep._context.Users.Add(newUser);
                    rep._context.SaveChanges();

                    return Json("OK");
                }

                return Json("O usuario já esta cadastrado, favor realizar o login", HttpStatusCode.BadRequest);
            }
            catch (Exception e)
            {
                return Json("Houve um erro interno, já estamos verificando!", HttpStatusCode.InternalServerError);
            }
        }
    }
}
