using ApiDotnetRobusta.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnetRobusta.Domain.Entities
{
    public sealed class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public ICollection<Purchase> Purchases { get; set; }

        public Person(string name, string document, string phone)
        {
            Validation(document, name, phone);
            Purchases = new List<Purchase>();
        }
        public Person(int id,string name,string phone, string document )
        {
            DomainValidationException.When(id <= 0, "id dever ser maior que zero");
            Id = id;
            Validation(document, name, phone);
            Purchases = new List<Purchase>();
        }
        private void Validation(string document, string phone, string name)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "name dever ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(document), "o document dever ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "o phone dever ser informado");

            Name = name;
            Phone = phone;
            Document = document;
        }
    }
}
