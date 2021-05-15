using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Card_File.BLL.DTO;

namespace Card_File.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task CreateCategoryAsunc(CategoryDto category);
        Task UpdateCategoryAsync(CategoryDto category);
        Task DeleteCategoryByIdAsync(int id);
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryByIdWithDetailsAsync(int id);
        Task<IEnumerable<CategoryDto>> GetCategoriesWithDetailsAsync();
        Task<IEnumerable<CategoryDto>> FindCetegoryesAsync(string term);

    }
}
