using SuTakip.BLL.Repository.Base;
using SuTakip.DAL.DB;

namespace SuTakip.BLL.Repository.Entity
{
    public class MusteriRepository : BaseRepository<Musteri>
    {
        public bool MusteriGuncelle(Musteri data)
        {
            bool result;
            Musteri dbresult = this.FindWithID(data.ID);

            if (dbresult != null)
            {
                dbresult.MusteriFirma = data.MusteriFirma;
                dbresult.YetkiliAdSoyad = data.YetkiliAdSoyad;
                dbresult.Telefon = data.Telefon;
                dbresult.Email = data.Email;
                dbresult.Adres = data.Adres;
                dbresult.Toptanmi = data.Toptanmi;
                dbresult.IskontoOran = data.IskontoOran;
                dbresult.AktifMi = data.AktifMi;

                this.Save();
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
