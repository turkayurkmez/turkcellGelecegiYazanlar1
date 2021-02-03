using Microsoft.EntityFrameworkCore;
using miniShop.Data;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class ProductService : IProductService
    {
        private miniShopDbContext dbContext;

        public ProductService(miniShopDbContext dbContext)
        {
             this.dbContext = dbContext;
        }

        public void AddProduct(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public Product GetProductById(int id)
        {
            return dbContext.Products.Find(id);

        }

        public List<Product> GetProducts()
        {
            var products = dbContext.Products.AsNoTracking().ToList();
            return products;
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return dbContext.Products.AsNoTracking().Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
