using layoutdesign.Data;
using layoutdesign.Interfaces;
using layoutdesign.Models;
using Microsoft.EntityFrameworkCore;

namespace layoutdesign.Repository
{
    public class Categoryrepo : Icategory
    {
        private readonly ApplicationDBContext _context;

        public Categoryrepo(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task<Category> AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<Category> DeleteCategory(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public Task<Category> GetCategoryById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
