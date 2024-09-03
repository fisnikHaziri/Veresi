using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IPersonRepository
    {
        public Task<List<Person>> GetAll();
        public Task<Person> GetById(Guid id);
        public Task<bool> Create(Person person);
        public Task<bool> Edit(Person person);
        public Task<bool> Delete(Person person);
    }
}
