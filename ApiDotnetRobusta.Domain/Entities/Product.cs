using ApiDotnetRobusta.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnetRobusta.Domain.Entities
{
    public sealed class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string CodErp { get; private set; }
        public decimal Price { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        public Product(string name, string coderp, decimal price)
        {
            Validation(name, coderp, price);
            Purchases = new List<Purchase>();
        }
        public Product(int id,string name, string coderp, decimal price)
        {
            DomainValidationException.When(id < 0, "id do produto dever ser informado");
            Id = id;
            Validation(name, coderp, price);
            Purchases = new List<Purchase>();
        }
        public void Validation(string name, string coderp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name),"o name dever ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(coderp),"o code dever ser informado");
            DomainValidationException.When(price < 0,"o name dever ser informado");

            Name = name;
            CodErp = coderp;
            Price = price;
        }
    }
}
