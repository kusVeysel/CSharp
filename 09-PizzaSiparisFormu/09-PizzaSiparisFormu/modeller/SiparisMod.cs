using System.Collections.Generic;

namespace Pizza.Modeller
{
    public class SiparisMod
    {
        public Musteri MusteriInfo { get; set; }
        public List<Urun> UrunBilgileri { get; set; }
        public int PizzaAdet { get; set; }
        public int IcecekAdet { get; set; }
        public double ToplamTutar { get; set; }
    }
}
