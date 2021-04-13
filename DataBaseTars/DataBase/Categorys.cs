using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseTars.DataBase
{
    public class Categorys
    {
        public long CategoryID { get; set; }
        public long UserID { get; set; }
        public string Name { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
    }

    public class CategorysConfiguration : IEntityTypeConfiguration<Categorys>
    {
        public void Configure(EntityTypeBuilder<Categorys> builder)
        {
            builder.HasKey(prop => prop.CategoryID);
            builder.Property(prop => prop.UserID);
            builder.Property(prop => prop.Name).IsRequired();
            builder.Property(prop => prop.Created_at);
            builder.Property(prop => prop.Updated_at);
            builder.Property(prop => prop.Deleted_at);
            builder.ToTable("Categorys");
        }
    }
}
