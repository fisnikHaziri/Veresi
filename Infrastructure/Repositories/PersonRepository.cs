using Infrastructure.Data;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _context;
        public PersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Person>> GetAll()
        {
            var People = await _context.people.
                Include(p => p.Debts)
                .ToListAsync();
            return People;
        }

        public async Task<Person> GetById(Guid id)
        {
            return await _context.people
                .Include(p => p.Debts)
                .FirstOrDefaultAsync(p => p.id == id);
        }
        public async Task<bool> Create(Person person)
        {
            _context.people.AddAsync(person);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Edit(Person person)
        {
            _context.people.Update(person);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> Delete(Person person)
        {
            _context.people.Remove(person);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
