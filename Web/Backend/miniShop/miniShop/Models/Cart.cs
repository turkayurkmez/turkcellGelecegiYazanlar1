using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models
{
    public class Cart
    {
        private List<ProductInCart> products = new List<ProductInCart>();
        public void AddItem(Product product, int quantity)
        {
            var existingProduct = products.FirstOrDefault(x => x.Product.Id == product.Id);
            if (existingProduct == null)
            {
                products.Add(new ProductInCart { Product = product, Quantity = quantity });
            }
            else
            {
                existingProduct.Quantity += quantity;
            }
        }

        public void Remove(Product product) => products.RemoveAll(x => x.Product.Id == product.Id);

        public void Clear() => products.Clear();

        public decimal GetTotalValue() => products.Sum(x => x.Product.Price * x.Quantity);

        public IEnumerable<ProductInCart> Products => products;

    }
}
