using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Lütfen Ürün Adını Giriniz.")]
        [Display(Name = "Urun Adı")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Lütfen Ürün Fiyatını Giriniz.")]
        [Range(0,1000000)]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        
        [Display(Name = "Resim")]
        public string? Image { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Lütfen Kategori Id Giriniz.")]
        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }
    }
}
