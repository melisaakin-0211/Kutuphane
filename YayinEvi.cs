using System.ComponentModel.DataAnnotations;

namespace KutuphaneWeb.Models
{
    public class YayinEvi
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Yayınevi adı zorunludur.")]
        [StringLength(50)]
        [Display(Name = "Adı")]
        public string Adi { get; set; } = string.Empty;

        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
