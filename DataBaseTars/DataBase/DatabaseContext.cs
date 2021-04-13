using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseTars.DataBase
{
    public class DatabaseContext : DbContext

    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategorysConfiguration());
            builder.ApplyConfiguration(new ProductsConfiguration());
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
