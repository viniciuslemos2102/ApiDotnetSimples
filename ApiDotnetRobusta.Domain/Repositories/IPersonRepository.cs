using ApiDotnetRobusta.Domain.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnetRobusta.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetByIdAsync(int id);
        Task<ICollection> GetByPeopleAsync(string name);
        Task<Person> CreateAsync(Person person);
        Task EditeAsync(Person person);
        Task DeleteAsync(Person person);

    }
}
