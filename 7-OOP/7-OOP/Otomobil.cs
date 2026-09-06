namespace _7_OOP
{
    public class Otomobil : Tasit
    {
        public int KoltukSayisi { get; set; }
        public bool KullanimTipi { get; set; } // true ise şahsi, false ise ticari
        public string VitesTipi { get; set; }
        public string KasaTipi { get; set; }
    }
}
