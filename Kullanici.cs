using System.ComponentModel.DataAnnotations;

namespace KutuphaneWeb.Models
{
    public class Kullanici
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad Soyad zorunludur.")]
        [StringLength(50)]
        [Display(Name = "Adı Soyadı")]
        public string Adi { get; set; } = string.Empty;

        [Required(ErrorMessage = "Şifre zorunludur.")]
        [StringLength(100)]
        public string Sifre { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "Rol")]
        public string Role { get; set; } = "Kullanici"; // "Admin" veya "Kullanici"

        public ICollection<Alisveris>? Alisverisler { get; set; }
    }
}
