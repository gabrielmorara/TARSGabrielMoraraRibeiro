using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseTars.DataBase
{
    public class Products
    {
        public long ProductID { get; internal set; }
        public long CategoryID { get; internal set; }
        public long UserID { get; internal set; }
        public string Title { get; internal set; }
        public string Brand { get; internal set; }
        public DateTime? Created_at { get; internal set; }
        public DateTime? Updated_at { get; internal set; }
        public DateTime? Deleted_at { get; internal set; }
    }
    public class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(prop => prop.ProductID);
            builder.Property(prop => prop.CategoryID);
            builder.Property(prop => prop.UserID);
            builder.Property(prop => prop.Title).IsRequired();
            builder.Property(prop => prop.Created_at);
            builder.Property(prop => prop.Updated_at);
            builder.Property(prop => prop.Deleted_at);
            builder.ToTable("Products");
        }
    }
}
