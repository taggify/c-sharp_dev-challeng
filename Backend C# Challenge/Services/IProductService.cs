using Backend_C_Challenge.Models;

namespace Backend_C__Challenge.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(long productId);    
        Task<Result> UpdateProduct(long productId, Product product);
        Task<Result> CreateProduct(Product product);
        Task<Result> DeleteProduct(long productId);
    }

}
