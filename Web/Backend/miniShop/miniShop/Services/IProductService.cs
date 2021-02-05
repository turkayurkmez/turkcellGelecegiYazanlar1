﻿using miniShop.Models;
using System.Collections.Generic;

namespace miniShop.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Product> GetProductsByCategoryId(int categoryId);
        void AddProduct(Product product);
        Product GetProductById(int id);
        int EditProduct(Product product);
    }
}