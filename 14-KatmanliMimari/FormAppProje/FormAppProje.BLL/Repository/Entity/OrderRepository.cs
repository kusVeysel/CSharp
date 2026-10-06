using FormAppProje.BLL.DTO;
using FormAppProje.BLL.Repository.Base;
using FormAppProje.DAL.DB;

namespace FormAppProje.BLL.Repository.Entity
{
    public class OrderRepository : BaseRepository<Orders>
    {
        public SiparisDetaySiparisDTO SiparisBilgiGetir(int ID)
        {
            Orders dbOrd = this.Find2(ID);

            SiparisDetaySiparisDTO dto = new SiparisDetaySiparisDTO();
            dto.SiparisID = dbOrd.OrderID;
            dto.MusteriAdi = dbOrd.Customers.ContactName;
            dto.KategoriTarihi = dbOrd.ShippedDate == null ? "Tarih Yok" : dbOrd.ShippedDate.Value.ToString("dd-MM-yyyy");
            dto.SiparisTarihi = dbOrd.OrderDate == null ? "Tarih Yok" : dbOrd.OrderDate.Value.ToString("dd-MM-yyyy");

            return dto;
        }
    }
}
