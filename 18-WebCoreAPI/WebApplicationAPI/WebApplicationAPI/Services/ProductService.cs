using WebApplicationAPI.Models;
using WebApplicationAPI.Repository;

namespace WebApplicationAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Delete(int ID)
        {
            var product = _productRepository.GetByID(ID);
            if (product == null)
                throw new Exception("Ürün Bulunamadı!");

            _productRepository.Delete(product);
            _productRepository.Save();
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product? GetByID(int ID)
        {
            var product = _productRepository.GetByID(ID);
            if (product == null)
                throw new Exception("Ürün Bulunamadı!");

            return product;
        }

        public void Update(int ID, Product product)
        {
            var existingProduct = _productRepository.GetByID(ID);
            if (existingProduct == null)
                throw new Exception("Ürün Bulunamadı!");

            existingProduct.ProductName = product.ProductName;
            existingProduct.Price = product.Price;
            existingProduct.Stock = product.Stock;

            _productRepository.Update(existingProduct);
            _productRepository.Save();
        }
    }
}
