using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.WebUI.Models
{
    public class OrderModel
    {
        public CartModel CartModel { get; set; }
        [Display(Name ="İsim")]
        public string  FirstName { get; set; }
        [Display(Name = "Soyisim")]
        public string LastName { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name = "Şehir")]
        public string City { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Ay")]
        public string ExpirationMonth { get; set; }
        [Display(Name = "Yıl")]
        public string ExpirationYear { get; set; }
        [Display(Name = "CVV")]
        public string Cvv { get; set; }
        public string CartNumber { get; set; }
        public string CartName { get; set; }
    }
}
