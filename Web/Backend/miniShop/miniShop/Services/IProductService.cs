using miniShop.Models;
using System.Collections.Generic;

namespace miniShop.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}