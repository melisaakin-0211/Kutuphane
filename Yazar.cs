using System.ComponentModel.DataAnnotations;

namespace KutuphaneWeb.Models
{
    public class Yazar
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Yazar adı zorunludur.")]
        [StringLength(50)]
        [Display(Name = "Adı")]
        public string Adi { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Display(Name = "Doğum Tarihi")]
        public DateTime? DogumTarihi { get; set; }

        [Display(Name = "Açıklama")]
        public string? Aciklama { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
