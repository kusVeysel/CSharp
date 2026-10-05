namespace SuTakip.BLL.Repository.Models
{
    public class MusteriGuncelleDTO
    {
        public int ID { get; set; }
        public string FirmaAdi { get; set; }
        public string YetkiliAdSoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public int Iskonto { get; set; }
        public bool AktifMi { get; set; }
        public bool ToptanMi { get; set; }
    }
}
