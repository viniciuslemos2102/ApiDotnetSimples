using ApiDotnetRobusta.Domain.Context;
using ApiDotnetRobusta.Domain.Entities;
using ApiDotnetRobusta.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ApiDotnet.Robusta.Infra.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _db;
        public PersonRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Person> CreateAsync(Person person)
        {
            _db.Add(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task DeleteAsync(Person person)
        {
            _db.Remove(person);
            await _db.SaveChangesAsync();
        }

        public async Task EditeAsync(Person person)
        {
            _db.Update(person);
            await _db.SaveChangesAsync();
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _db.people.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<ICollection> GetByPeopleAsync(string name)
        {
            return await _db.people.ToListAsync();
        }
    }
}
