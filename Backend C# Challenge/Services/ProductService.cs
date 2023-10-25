using Backend_C_Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_C__Challenge.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
        
        public async Task<Product> GetProduct(long id)
        {
            return await _context.Products.FindAsync(id);;
        }

        public async Task<Result> UpdateProduct(long id, Product product)
        {
            if (id != product.Id)
            {
                return Result.BadRequest;
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return Result.Success;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return Result.NotFound;
                }
                    else
                {
                    throw;
                }
            }
        }
        public async Task<Result> CreateProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return Result.Success;
            }
            catch (Exception)
            {
                return Result.BadRequest;
            }
        }

        public async Task<Result> DeleteProduct(long id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return Result.NotFound;
            }

            _context.Products.Remove(product);

            try
            {
            await _context.SaveChangesAsync();
                return Result.Success;
            }
                catch (Exception)
            {
                return Result.BadRequest;
            }

        }

        private bool ProductExists(long id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }

}
