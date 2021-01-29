using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="İsmi olmayan ürün mü olur be!")]
        [Display(Name="Ürün Adı")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen açıklama giriniz...")]
        [Display(Name = "Açıklama")]

        public string Description { get; set; }
        public double Rating { get; set; }
        [Display(Name = "Fiyat")]

        public decimal Price { get; set; }
        public double Discount { get; set; }

        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
