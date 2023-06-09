﻿using FirstApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Data
{
    public class ProductsContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductsContext(DbContextOptions<ProductsContext> options)
           : base(options)
        {
            //Database.EnsureCreated();
        }

    }
}
