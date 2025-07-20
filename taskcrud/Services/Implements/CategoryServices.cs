using AutoMapper;
using Microsoft.EntityFrameworkCore;
using taskcrud.DAL;
using taskcrud.DTOs.Categories;
using taskcrud.Entities;
using taskcrud.Services.Abstracts;

namespace taskcrud.Services.Implements
{
    public class CategoryServices(TaskDbContext _context,IMapper _mapper) : ICategoryServices
    {
        public async Task CreateAsync(CategoryCreateDto dto)
        {
            bool isExist = await _context.Categories.AnyAsync(c => c.Name.Trim().ToLower() == dto.Name.Trim().ToLower());
            if (isExist) throw new Exception("Bu adda category artıq mövcuddur");
            var category = _mapper.Map<Category>(dto);
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                throw new Exception("Category tapılmadı");
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryGetDto>> GetAllAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return _mapper.Map<IEnumerable<CategoryGetDto>>(categories);
        }
        public async Task UpdateAsync(int id, CategoryUpdateDto dto)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
                throw new Exception("Category tapılmadı");

            bool isExist = await _context.Categories
                .AnyAsync(c => c.Name.ToLower().Trim() == dto.Name.ToLower().Trim() && c.Id != id);

            if (isExist)
                throw new Exception("Bu adda category artıq mövcuddur");

            category.Name = dto.Name;
            category.IsEnable = dto.IsEnable;

            await _context.SaveChangesAsync();
        }

    }
}
