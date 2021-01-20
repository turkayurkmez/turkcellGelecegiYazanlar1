using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {

        
        static void Main(string[] args)
        {
            var anonim = new { Ad = "Türkay", Soyad = "Ürkmez" };

            var x = 5;
            var kelime = "Turkcell";
            var urun = new Product() { Id = 1, Name = "Telefon", Price = 7000 };


            var pro2 = GetProduct();

            var list = new ProductList();
            list.Add(new Product { Id = 1, Name = "Iphone XII", Price = 24000});
            list.Add(new Product { Id = 2, Name = "Huawei Pro", Price = 8000 });
            list.Add(new Product { Id = 3, Name = "Xiaomi", Price = 4500 });
            list.Add(new Product { Id = 4, Name = "Iphone XI", Price = 12000 });

            var findings = list.GetProductsByName("Iphone");
            findings.ForEach(product => Console.WriteLine($"{product.Name} isimli ürün {product.Price} TL"));

            var product2 = list.GetProduct(3);
            Console.WriteLine($"{product2.Name},  {product2.Price} TL");



            Console.ReadLine();


        }

        static Product GetProduct()
        {
            return new Product { Name = "X", Price = 100 };
        }
    }
}
