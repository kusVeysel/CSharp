using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP
{
    public class Tasit
    {
        public int TekerlekSayisi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime ModelYili { get; set; }
        public int BeygirGucu { get; set; }
        public string YonetimSekli { get; set; }
        public string Renk { get; set; }
        public string KullanimAlani { get; set; }
        public string YakitTuru { get; set; }

        // prop yazıp tab'a basarak propertyler oluşturulur
        // OOP'de get veriyi çekmek okumak için kullanılır ,set ise veriyi güncellemek için kullanılır. get olmak zorundadır ama set olmasa da olur
        //public string A { get; } = "Taşıt"; // default olarak Taşıt atanır ve bu değer değiştirilemez
    }
}
