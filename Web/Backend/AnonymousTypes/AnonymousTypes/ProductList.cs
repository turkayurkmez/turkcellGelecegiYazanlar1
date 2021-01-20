using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
   public class ProductList
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProductsByName(string name)
        {
            return products.Where(p => p.Name.Contains(name)).ToList();
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);

        }
    }
}
