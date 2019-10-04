using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.WebUI.Models
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Parola")]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
