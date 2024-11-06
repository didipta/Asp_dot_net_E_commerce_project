﻿using layoutdesign.Models;

namespace layoutdesign.Interfaces
{
    public interface Icategory
    {
        Task<List<Category>> GetCategories();
        Task<Category> GetCategoryById(Int64 id);

        Task<Category> AddCategory(Category category);

        Task<Category> UpdateCategory(Category category);

        Task<Category> DeleteCategory(Int64 id);
    }
}