using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models
{
    //Sepetteki bir ürün:
    public class ProductInCart
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
