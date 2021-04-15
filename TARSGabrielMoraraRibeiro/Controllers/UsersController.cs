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
            return ValidateUser();
        }

        // Verifica se o usuario esta registrado para autentificar 
        [HttpGet]
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

        [HttpGet]
        public JsonResult GetUser()
        {
            try
            {
                var userCPF = HttpContext.Request.Cookies["UserCPF"];
                var userToken = HttpContext.Request.Cookies["UserToken"];

                var user = rep.GetUserByCPF(userCPF);

                return Json(user);
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

                    return Json(passswordEncrypt);
                }

                return new JsonResult("O usuario já esta cadastrado, favor realizar o login")
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

        [HttpPut]
        public JsonResult UpdateUser(string name, string email, string oldPassword, string newPassword)
        {
            try
            {
                var userCPF = HttpContext.Request.Cookies["UserCPF"];

                var user = rep.GetUserByCPF(userCPF);

                if (user != null)
                {
                    var oldPassswordEncrypt = Common.ConvertedPassword.Encrypt(oldPassword);
                    if (oldPassswordEncrypt.Equals(user.Password_hash))
                    {
                        var newPassswordEncrypt = Common.ConvertedPassword.Encrypt(newPassword);

                        user.Name = name;
                        user.Email = email;
                        user.Password_hash = newPassswordEncrypt;
                        user.Updated_at = Common.Commons.HourBrasilia;

                        rep._context.SaveChanges();

                        return Json(newPassswordEncrypt);
                    }

                    return new JsonResult("A senha atual está incorreta.")
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest
                    };
                }

                return new JsonResult("Erro, CPF não encontrado.")
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
