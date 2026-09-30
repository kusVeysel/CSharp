using APIApplication.DB;
using APIApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIApplication.Controllers
{
    [RoutePrefix("api/Product")] // Action'ların kök adresi
    public class ProductController : BaseController
    {
        [HttpGet] // Action'ın tipi
        [Route("UrunGetir")] // Action'ın adresi
        public List<UrunApiVM> UrunListesi() // Burdaki UrunListesi ile api çekilmez bu ezilir(Route'den dolayı), bu method açıklama gibi uzun uzadıya yazılabilir.
        {
            List<Urun> dbResult = db.Urun.ToList();
            List<UrunApiVM> resultList = new List<UrunApiVM>();

            foreach (Urun item in dbResult)
            {
                UrunApiVM vm = new UrunApiVM()
                {
                    ID = item.ID,
                    UrunAdi = item.UrunAdi,
                    ListeFiyat = item.ListeFiyat.FirstOrDefault(x => x.UrunID == item.ID) == null ? 0 : (double)item.ListeFiyat.FirstOrDefault(x => x.UrunID == item.ID).BirimFiyat,
                    Stok = item.StokTablo.FirstOrDefault(x => x.UrunID == item.ID) == null ? 0 : (int)item.StokTablo.FirstOrDefault(x => x.UrunID == item.ID).Stok
                };

                resultList.Add(vm);
            } // DynamicProxies engellemek için kullanılır.

            return resultList;
        }
    }
}