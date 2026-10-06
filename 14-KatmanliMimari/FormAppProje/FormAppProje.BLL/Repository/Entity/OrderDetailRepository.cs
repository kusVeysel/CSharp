using FormAppProje.BLL.DTO;
using FormAppProje.BLL.Repository.Base;
using FormAppProje.DAL.DB;
using System.Collections.Generic;
using System.Linq;

namespace FormAppProje.BLL.Repository.Entity
{
    public class OrderDetailRepository : BaseRepository<Order_Details>
    {
        public List<DetayListe> SiparisDetayListeGetir(int ID)
        {
            List<DetayListe> dtoDetayListe = new List<DetayListe>();

            List<Order_Details> dbOrdDeta = this.GetAll2().Where(x => x.OrderID == ID).ToList();


            foreach (Order_Details od in dbOrdDeta)
            {
                DetayListe dl = new DetayListe()
                {
                    Adet = od.Quantity,
                    BirimFiyat = (double)od.UnitPrice,
                    IndirimOrani = od.Discount,
                    UrunAdi = od.Products.ProductName,
                    UrunToplam = (double)(od.Quantity * od.UnitPrice),
                };
                dtoDetayListe.Add(dl);
            }

            return dtoDetayListe.Distinct().ToList();
        }
    }
}
