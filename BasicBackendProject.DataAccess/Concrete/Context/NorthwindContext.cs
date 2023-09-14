using BasicBackendProject.Entities.Concrete;
using BasicBackendProject.Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.DataAccess.Concrete.Context
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\waali\OneDrive\Masaüstü\BackendProject\BasicBackendProject\BasicBackendProject.DataAccess\Database1.mdf;Integrated Security=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductDetailDto> ProductDetailDtos { get; set; }

    }
}
