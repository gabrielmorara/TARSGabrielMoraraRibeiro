using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseTars.DataBase
{
    public class Products
    {
        public long ProductID { get; set; }
        public long CategoryID { get; set; }
        public long UserID { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string ean { get; set; }
        public string ncm { get; set; }
        public int Stock { get; set; }
        public int Warranty { get; set; }
        public decimal PriceDefault { get; set; }
        public decimal PriceOffer { get; set; }
        public decimal Height { get; set; }
        public decimal Lenght { get; set; }
        public decimal Width { get; set; }
        public decimal Weight { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Deleted_at { get; set; }
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
