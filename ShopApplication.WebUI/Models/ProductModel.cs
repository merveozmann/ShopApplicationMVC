using ShopApplication.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        //[Required]
        //[StringLength(60,MinimumLength =10,ErrorMessage ="Ürün İsmi Minimun 10 karakter ve maksimum 60 karakter olmalıdır")]
        [Display(Name ="Ürün Adı")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Ürün Resmi")]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Ürün Açıklama")]
        [StringLength(10000, MinimumLength = 20, ErrorMessage = "Ürün açıklaması Minimun 20 karakter ve maksimum 100 karakter olmalıdır")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Fiyat belirtiniz")]
        [Range(1,10000)]
        [Display(Name = "Ürün Fiyat")]
        public decimal? Price { get; set; }

        public List<Category> SelectedCategories { get; set; }
    }
}
