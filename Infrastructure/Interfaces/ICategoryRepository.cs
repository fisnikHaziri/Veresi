using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetAll();
        public Task<Category> GetById(Guid id);
        public Task<bool> Create(Category category);
        public Task<bool> Edit(Category category);
        public Task<bool> Delete(Category category);
    }
}
