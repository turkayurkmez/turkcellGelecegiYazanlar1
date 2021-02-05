using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Security.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Currency)]        
        public decimal Price { get; set; }

        public string Description { get; set; }

    }
}
