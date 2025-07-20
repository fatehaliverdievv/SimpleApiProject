using taskcrud.DTOs.Categories;

namespace taskcrud.Services.Abstracts
{
    public interface ICategoryServices
    {
        Task<IEnumerable<CategoryGetDto>> GetAllAsync();
        Task CreateAsync(CategoryCreateDto dto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, CategoryUpdateDto dto);

    }
}
