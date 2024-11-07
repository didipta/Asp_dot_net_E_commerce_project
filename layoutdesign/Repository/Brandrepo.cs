using layoutdesign.Data;
using layoutdesign.Interfaces;
using layoutdesign.Models;
using Microsoft.EntityFrameworkCore;

namespace layoutdesign.Repository
{
    public class Brandrepo : Ibrand
    {
        private readonly ApplicationDBContext _context;

        public Brandrepo(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task<Brand> AddBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> DeleteBrand(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Brand> GetBrandById(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _context.Brands.Where(x => x.IsActive == false).ToListAsync();
        }

        public Task<Brand> UpdateBrand(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
