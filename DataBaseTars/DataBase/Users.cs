using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataBaseTars.DataBase
{
    public class Users
    {
        public long UserID { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Password_hash { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
    }

    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(prop => prop.UserID);
            builder.Property(prop => prop.Name).IsRequired();
            builder.Property(prop => prop.Cpf).IsRequired();
            builder.Property(prop => prop.Email).IsRequired();
            builder.Property(prop => prop.Created_at);
            builder.Property(prop => prop.Updated_at);
            builder.Property(prop => prop.Deleted_at);
            builder.ToTable("Users");
        }
    }
}