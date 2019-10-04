using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.WebUI.Models
{
    public class RegisterModel
    {
        [Required]
        [Display(Name ="İsim-Soyisim")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string RePassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
