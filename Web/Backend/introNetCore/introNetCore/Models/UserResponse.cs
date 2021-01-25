using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace introNetCore.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz....")]
        [MinLength(2,ErrorMessage ="En az iki harf giriniz")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz...")]
        [EmailAddress(ErrorMessage = "E-posta formatı doğru değil!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen katılım durumunu seçiniz...")]
        public bool IsAccepted { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
