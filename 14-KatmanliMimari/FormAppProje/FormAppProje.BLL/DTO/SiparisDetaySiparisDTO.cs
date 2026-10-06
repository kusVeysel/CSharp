using System.Collections.Generic;

namespace FormAppProje.BLL.DTO
{
    public class SiparisDetaySiparisDTO
    {

        public int SiparisID { get; set; }
        public string MusteriAdi { get; set; }
        public string SiparisTarihi { get; set; }
        public string KategoriTarihi { get; set; }
        public double SiparisToplam { get; set; }
        public List<DetayListe> SiparisDetayListesi { get; set; }

    }

}

