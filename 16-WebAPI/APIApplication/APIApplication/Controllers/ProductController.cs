using APIApplication.DB;
using APIApplication.Models;
using Swashbuckle.Swagger.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIApplication.Controllers
{

    [RoutePrefix("api/Product")] // Action'ların kök adresi
    public class ProductController : BaseController
    {
        [HttpGet] // Action'ın tipi
        [Route("UrunListe")] // Action'ın adresi
        [SwaggerOperation(Tags = new[] { "Ürün İşlemleri" })] // Swagger'da hangi tag altında görüneceği
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

        /// <summary>
        /// Ürün ID Bilgisine göre ürün detaylarını getirir.
        /// </summary>
        /// <param name = "ID">Ürün ID Bilgisi</param>
        /// <returns></returns>
        // projeye sağ tık -> properties -> build -> XML document file

        [HttpGet] // Action'ın tipi
        [Route("UrunGetir/{id}")] // Action'ın adresi
        [SwaggerOperation(Tags = new[] { "Ürün İşlemleri" })] // Swagger'da hangi tag altında görüneceği
        public UrunApiVM UrunDetay(int ID) // Burdaki UrunListesi ile api çekilmez bu ezilir(Route'den dolayı), bu method açıklama gibi uzun uzadıya yazılabilir.
        {
            Urun dbResult = db.Urun.Find(ID);
            UrunApiVM result = new UrunApiVM();

            result.ID = dbResult.ID;
            result.UrunAdi = dbResult.UrunAdi;
            result.ListeFiyat = dbResult.ListeFiyat.FirstOrDefault(x => x.UrunID == dbResult.ID) == null ? 0 : (double)dbResult.ListeFiyat.FirstOrDefault(x => x.UrunID == dbResult.ID).BirimFiyat;
            result.Stok = dbResult.StokTablo.FirstOrDefault(x => x.UrunID == dbResult.ID) == null ? 0 : (int)dbResult.StokTablo.FirstOrDefault(x => x.UrunID == dbResult.ID).Stok;
            // DynamicProxies engellemek için kullanılır.

            return result;
        }

        // ProductController, ürünlerle ilgili işlemleri gerçekleştiren bir API denetleyicisidir. Bu denetleyici, ürünlerin listesini almak ve belirli bir ürünün detaylarını getirmek için HTTP GET isteklerini işler. Swagger ile entegrasyon sayesinde, API dokümantasyonu ve testleri kolayca yapılabilir.
    }
}