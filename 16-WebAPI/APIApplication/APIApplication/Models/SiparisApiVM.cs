namespace APIApplication.Models
{
    public class SiparisApiVM
    {
        public int ID { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string SiparisTarih { get; set; }
        public string KargoTarih { get; set; }
        public string KargoAdres { get; set; }
    }
}