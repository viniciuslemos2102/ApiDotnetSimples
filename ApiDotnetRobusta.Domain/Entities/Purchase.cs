using ApiDotnetRobusta.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnetRobusta.Domain.Entities
{
    public sealed class Purchase
    {
        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonID { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; set; }
        public Product Product { get; set; }


        public Purchase( int personId, int prodctId, DateTime? date)
        {
            Validation(prodctId, personId, date);
        }
        public Purchase(int id ,int personId, int prodctId, DateTime? date)
        {
            DomainValidationException.When(id < 0, "o id dever ser informado");
            Id = id;
            Validation(prodctId, personId, date);
        }
        public void Validation( int personId, int prodctId, DateTime? date)
        {
            
            DomainValidationException.When(prodctId < 0, "o id do produto dever ser informado");
            DomainValidationException.When(personId < 0, "o id da pessoa dever ser informado");
            DomainValidationException.When(!date.HasValue, "a data dever ser informado");

            ProductId = prodctId;
            PersonID = personId;
            Date = date.Value;
        }
    }
}
