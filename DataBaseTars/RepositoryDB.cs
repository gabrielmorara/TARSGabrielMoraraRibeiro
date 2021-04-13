using DataBaseTars.DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DataBaseTars
{
    public class RepositoryDB : IDisposable
    {
        public DataBaseTars.DataBase.DatabaseContext _context = null;

        public RepositoryDB()
        {
            if (_context == null)
            {
                var contextOptions = new DbContextOptionsBuilder<DatabaseContext>().UseNpgsql(@"Host=localhost;Port=5432;Pooling=true;Database=tars;User Id=tars;Password=tars;").Options;
                _context = new DatabaseContext(contextOptions);
            }
        }

        public bool ValidateUser(string cpf, string token)
        {
            try
            {
                var user = GetUserByCPF(cpf);
                if (user != null)
                {
                    return user.Password_hash.Equals(token);
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Users GetUserByCPF(string cpf)
        {
            try
            {
                var _cpf = GetOnlyNumber(cpf);
                return _context.Users.FirstOrDefault(s => s.Cpf.Equals(_cpf));
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static string GetOnlyNumber(String resource)
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(resource, @"[^\d]"));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
