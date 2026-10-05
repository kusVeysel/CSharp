using SuTakip.BLL.Repository.Base;
using SuTakip.BLL.Repository.Models;
using SuTakip.DAL.DB;
using System.Linq;


namespace SuTakip.BLL.Repository.Entity
{
    public class AdminRepository : BaseRepository<Admin>
    {
        public Result AdminCheck(string userName, string password)
        {
            Admin dbresult;
            Result result = new Result();

            try
            {
                dbresult = this.GetAll().Where(a => a.UserName == userName && a.Password == password).First();
            }
            catch
            {
                dbresult = new Admin();
            }

            if (dbresult.ID > 0)
            {
                if (dbresult.AktifMi == true)
                {
                    result.AktifMi = true;
                    result.Gec = true;
                    result.BosVeri = false;
                    result.Message = "Giriş başarılı.";

                    return result;
                }
                result.AktifMi = false;
                result.Gec = false;
                result.BosVeri = false;
                result.Message = "Kullanıcı pasif durumda yönetici ile iletişime geçin.";

                return result;

            }
            else
            {
                result.AktifMi = false;
                result.Gec = false;
                result.BosVeri = true;
                result.Message = "Kullanıcı bulunamadı, şifre veya kullanıcı adı hatalı.";

                return result;

            }

        }
    }
}
