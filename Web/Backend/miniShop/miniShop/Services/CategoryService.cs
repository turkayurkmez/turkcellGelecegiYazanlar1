using Microsoft.EntityFrameworkCore;
using miniShop.Data;
using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class CategoryService : ICategoryService
    {
        private miniShopDbContext dbContext;

        public CategoryService(miniShopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IList<Category> GetCategories()
        {
            return dbContext.Categories.AsNoTracking().ToList();
        }
    }
}
