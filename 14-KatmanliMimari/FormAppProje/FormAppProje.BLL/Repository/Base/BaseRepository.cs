using FormAppProje.DAL.DB;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FormAppProje.BLL.Repository.Base
{
    public class BaseRepository<T> where T : class // BaseRepository, dışarıdan gelen T tipini sınırlamak için "where T : class" ifadesini kullanır. Bu, T'nin bir referans tipi (class) olmasını sağlar.Generic list tipindedir.
    {
        private VeyselEntities db;

        //protected: newlenemez ve private gibi özel olarak çalışır.

        protected DbSet<T> table;

        // yapıcı(constracter) method
        public BaseRepository()
        {
            db = new VeyselEntities();
            table = db.Set<T>(); // tablo yapısını db.Set<T>() ile alır ve table değişkenine atar. Bu sayede, T tipindeki veritabanı tablosuna erişim sağlanır.
        }

        public void Save()
        {
            db.SaveChanges();
        }

        // virtual:Default değer gibi düşünülebilir. Bu methodun alt sınıflarda override edilebileceğini belirtir. Yani, alt sınıflar bu methodu kendi ihtiyaçlarına göre değiştirebilir.
        public virtual void Insert(T obj)
        {
            table.Add(obj);
            Save(); // değişiklikleri kaydetmek için oluşturduğumuz Save() methodunu çağırır.
        }
        public List<T> GetAll()
        {
            return table.ToList(); // T tipindeki tüm verileri liste olarak döndürür.
        }
        public T Find(long ID)
        {
            return table.Find(ID); // T tipindeki veritabanı tablosunda ID ile eşleşen kaydı bulur ve döndürür.
        }

    }
}
