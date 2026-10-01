using WebApplicationAPI.Models;

namespace WebApplicationAPI.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product? GetByID(int ID);
        void Add(Product product);
        void Update(int ID, Product product);
        void Delete(int ID);
    }
}
