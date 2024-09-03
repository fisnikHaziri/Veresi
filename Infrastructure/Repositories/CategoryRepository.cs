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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAll()
        {
            var categories = await _context.categories
                .Include(c => c.Persons)
                .ToListAsync();
            return categories;
        }

        public async Task<Category> GetById(Guid id)
        {
            var category = await _context.categories
                .Include(c => c.Persons)
                .FirstOrDefaultAsync(c => c.id == id);
            return category;
        }

        public Task<bool> Create(Category category)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Edit(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Category category)
        {
            throw new NotImplementedException();
        }


    }
}
