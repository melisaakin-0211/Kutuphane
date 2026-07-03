namespace KutuphaneWeb.Models
{
    public class Alisveris
    {
        public int ID { get; set; }

        public int? KitapID { get; set; }
        public Kitap? Kitap { get; set; }

        public int? KullaniciID { get; set; }
        public Kullanici? Kullanici { get; set; }

        public DateTime? AlisZamani { get; set; }

        public DateTime? TeslimZamani { get; set; }

        public string? Aciklama { get; set; }

        public DateTime? KayitTarihi { get; set; }
        public string? KayitYapan { get; set; }
        public DateTime? DegisiklikTarihi { get; set; }
        public string? DegisiklikYapan { get; set; }
    }
}
