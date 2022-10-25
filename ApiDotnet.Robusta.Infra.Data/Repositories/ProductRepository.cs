using ApiDotnetRobusta.Domain.Context;
using ApiDotnetRobusta.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnet.Robusta.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            _db.Add(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task DeleteAsync(Product product)
        {
            _db.Remove(product);
            await _db.SaveChangesAsync();
        }

        public async Task EditeAsync(Product product)
        {
            _db.Update(product);
            await _db.SaveChangesAsync();
        }

        public async Task<Product> GetByIdAsync(int Id)
        {
            return await _db.products.FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<ICollection<Product>> GetProductsAsync()
        {
            return await _db.products.ToListAsync();
        }
    }
}
