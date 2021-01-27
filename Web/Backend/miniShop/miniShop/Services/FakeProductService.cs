using miniShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Services
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product{ Id=1, Name="Saat X", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=3, Name="Saat Y",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Örnek Açıklama", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=4, Name="Cüzdan",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Test", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=5, Name="Çanta",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Test 3", Price=139.90M, Discount=0.55, Rating = 4.2 },
                  new Product{ Id=2, Name="Pantolon",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Deneme", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=6, Name="Pantolon",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Deneme", Price=139.90M, Discount=0.55, Rating = 4.2 },
                  new Product{ Id=1, Name="Saat X", ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Kadın Kol Saati", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=3, Name="Saat Y",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Örnek Açıklama", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=4, Name="Cüzdan",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Test", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=5, Name="Çanta",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Test 3", Price=139.90M, Discount=0.55, Rating = 4.2 },
                  new Product{ Id=2, Name="Pantolon",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Deneme", Price=139.90M, Discount=0.55, Rating = 4.2 },
                new Product{ Id=6, Name="Pantolon",ImageUrl="https://cdn.dsmcdn.com/mnresize/415/622/ty8/product/media/images/20200729/16/6325872/16639396/1/1_org.jpg", Description="Deneme", Price=139.90M, Discount=0.55, Rating = 4.2 }

            };
        }
    }
}
