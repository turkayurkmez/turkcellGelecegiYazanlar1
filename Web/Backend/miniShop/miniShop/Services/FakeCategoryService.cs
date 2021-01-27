using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class FakeCategoryService : ICategoryService
    {
        public IList<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category{ Id =1, Name="Aksesuar"},
                new Category{ Id =2, Name="Giyim"},
            };
        }
    }
}
