namespace WebApplicationAPI.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        /// CRUD işlemler
        /// Create
        /// Read
        /// Update
        /// Delete

        List<T> GetAll();
        T? GetByID(int ID);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}
