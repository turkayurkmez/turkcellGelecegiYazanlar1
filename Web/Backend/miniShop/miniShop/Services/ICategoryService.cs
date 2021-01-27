using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
   public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}
