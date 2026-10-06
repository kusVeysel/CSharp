using SuTakip.DAL.DB;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace SuTakip.BLL.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        private VeyselEntities db;

        protected DbSet<T> table;

        public BaseRepository()
        {
            db = new VeyselEntities();
            table = db.Set<T>();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        // virutal ram gibi geçici bir alan oluşturuyoruz. Bu sayede diğer repositorylerde bu metodu override edebiliriz.
        public virtual void Insert(T entity)
        {
            table.Add(entity);
            Save();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public T FindWithID(int ID)
        {
            return table.Find(ID);
        }

    }
}
