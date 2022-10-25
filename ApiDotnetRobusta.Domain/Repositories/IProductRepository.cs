using ApiDotnetRobusta.Domain.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnet.Robusta.Infra.Data.Repositories
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int Id);
        Task <ICollection<Product>> GetProductsAsync();
        Task<Product> CreateAsync(Product product);
        Task EditeAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
