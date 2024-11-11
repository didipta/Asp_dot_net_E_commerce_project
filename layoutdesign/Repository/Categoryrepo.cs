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

        public async Task<List<Category>> AllCategories()
        {
            
            return await _context.Categories.ToListAsync();

        }

        public Task<Category> DeleteCategory(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> CategoryIsactive(long id)
        {
            var result= await _context.Categories.FindAsync(id);
            if (result != null)
            {
                //update isactive to true
               if(result.IsActive == false)
                {
                    result.IsActive = true;
                }
                else
                {
                    result.IsActive = false;
                }
                _context.Categories.Update(result);
                await _context.SaveChangesAsync();

                return result;
            }
            
            return null;
        }

        public async Task<List<Category>> GetCategories()
        {
            //active categorie
            return await _context.Categories.Where(x => x.IsActive==false).ToListAsync();
        }

        public async Task<Category> GetCategoryById(long id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public Task<Category> UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
