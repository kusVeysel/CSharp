using System.Collections.Generic;

namespace APIApplication.Models
{
    public class EmpApiVM
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public List<SiparisApiVM> SiparisListe { get; set; }

    }
}