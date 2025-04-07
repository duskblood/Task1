using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Models
{
    public class ProductRepository
    {
        private readonly WarehouseDbContext _context;

        public ProductRepository(WarehouseDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task AddAsync(Product product)
        {
            product.CreatedDate = DateTime.Now;
            product.LastModifiedDate = DateTime.Now;
            await _context.Products.AddAsync(product);
        }

        public async Task UpdateAsync(Product product)
        {
            var existingProduct = await _context.Products.FindAsync(product.Id);
            if (existingProduct != null)
            {
                _context.Entry(existingProduct).CurrentValues.SetValues(product);
                existingProduct.LastModifiedDate = DateTime.Now;
                _context.Entry(existingProduct).State = EntityState.Modified;
            }
        }

        public async Task DeleteAsync(Product product)
        {
            var existingProduct = await _context.Products.FindAsync(product.Id);
            if (existingProduct != null)
            {
                _context.Products.Remove(existingProduct);
            }
        }
    }
} 