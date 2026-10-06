using FormAppProje.DAL.DB;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FormAppProje.BLL.Repository.Base
{
    public class BaseRepository<T> where T : class // BaseRepository, dışarıdan gelen T tipini sınırlamak için "where T : class" ifadesini kullanır. Bu, T'nin bir referans tipi (class) olmasını sağlar.Generic list tipindedir.
    {
        private VeyselEntities db;
        private NorthwindEntities db2;

        //protected: newlenemez ve private gibi özel olarak çalışır.

        protected DbSet<T> table;
        protected DbSet<T> table2;

        // yapıcı(constracter) method
        public BaseRepository()
        {
            db = new VeyselEntities();
            db2 = new NorthwindEntities();
            table = db.Set<T>(); // tablo yapısını db.Set<T>() ile alır ve table değişkenine atar. Bu sayede, T tipindeki veritabanı tablosuna erişim sağlanır.
            table2 = db2.Set<T>(); // tablo yapısını db.Set<T>() ile alır ve table2 değişkenine atar. Bu sayede, T tipindeki veritabanı tablosuna erişim sağlanır.
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Save2()
        {
            db2.SaveChanges();
        }

        // virtual:Default değer gibi düşünülebilir. Bu methodun alt sınıflarda override edilebileceğini belirtir. Yani, alt sınıflar bu methodu kendi ihtiyaçlarına göre değiştirebilir.
        public virtual void Insert(T obj)
        {
            table.Add(obj);
            Save(); // değişiklikleri kaydetmek için oluşturduğumuz Save() methodunu çağırır.
        }
        public virtual void Insert2(T obj)
        {
            table2.Add(obj);
            Save2(); // değişiklikleri kaydetmek için oluşturduğumuz Save2() methodunu çağırır.
        }
        public List<T> GetAll()
        {
            return table.ToList(); // T tipindeki tüm verileri liste olarak döndürür.
        }
        public List<T> GetAll2()
        {
            return table2.ToList(); // T tipindeki tüm verileri liste olarak döndürür.
        }
        public T Find(long ID)
        {
            return table.Find(ID); // T tipindeki veritabanı tablosunda ID ile eşleşen kaydı bulur ve döndürür.
        }
        public T Find2(long ID)
        {
            return table2.Find(ID); // T tipindeki veritabanı tablosunda ID ile eşleşen kaydı bulur ve döndürür.
        }

    }
}
