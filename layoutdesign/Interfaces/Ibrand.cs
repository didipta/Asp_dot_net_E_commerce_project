using layoutdesign.Models;

namespace layoutdesign.Interfaces
{
    public interface Ibrand
    {
        Task<List<Brand>> GetBrands();
        Task<Brand> GetBrandById(Int64 id);

        Task<Brand> AddBrand(Brand brand);

        Task<Brand> UpdateBrand(Brand brand);

        Task<Brand> DeleteBrand(Int64 id);
    }
}
