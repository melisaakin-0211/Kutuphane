using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KutuphaneWeb.Models
{
    public class Kitap
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Kitap adı zorunludur.")]
        [StringLength(50)]
        [Display(Name = "Başlık")]
        public string Title { get; set; } = string.Empty;

        [StringLength(50)]
        [Display(Name = "Alt Başlık")]
        public string? SubTitle { get; set; }

        [Display(Name = "Yayınevi")]
        public int? YayinEviID { get; set; }
        public YayinEvi? YayinEvi { get; set; }

        [Display(Name = "Yazar")]
        public int? YazarID { get; set; }
        public Yazar? Yazar { get; set; }

        [StringLength(50)]
        [Display(Name = "Tür")]
        public string? Tur { get; set; }

        public ICollection<Alisveris>? Alisverisler { get; set; }

        [NotMapped]
        public bool Musait { get; set; } = true; // Kontrolcüde hesaplanır
    }
}
