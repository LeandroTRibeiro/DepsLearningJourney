using GetProducts.DB;
using GetProducts.Models;
using Microsoft.EntityFrameworkCore;

namespace GetProducts.Services;

public class ProductsServices
{
    private readonly Context _context;

    public ProductsServices(Context context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task AddProductAsync(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
    }

    public async Task AddProductsAsync(List<Product> products)
    {
        await _context.Products.AddRangeAsync(products);
        await _context.SaveChangesAsync();
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null)
        {
            throw new Exception("Product not found");
        }
        
        return product;
    }

    public async Task<List<Product>> GetProductsByCategoryIdAsync(string category)
    {
        return await _context.Products.Where(item => item.Category.Equals(category)).ToListAsync();
    }

    public async Task<List<Product>> GetProductsByName(string name)
    {
        return await _context.Products.Where(item => item.Name.Contains(name)).ToListAsync();
    }

    public async Task UploadProduct(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }
    
    public async Task RemoveProductAsync(Product product)
    {
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveProductsAsync(List<Product> products)
    {
        _context.Products.RemoveRange(products);
        await _context.SaveChangesAsync();
    }
}