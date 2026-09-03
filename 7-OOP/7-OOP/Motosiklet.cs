using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP
{
    public class Motosiklet : Tasit // Tasit sınıfını kalıtım aldı
    {
        public string KasaTipi { get; set; }
        public string VitesTipi { get; set; }
        public string AktarimTipi { get; set; }
        public int SilindirSayisi { get; set; }
        public int SilindirHacmi { get; set; }
        public int BakimAraligi { get; set; }

    }
}