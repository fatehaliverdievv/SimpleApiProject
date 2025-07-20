using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using taskcrud.DAL;
using taskcrud.DTOs.Categories;
using taskcrud.Entities;
using taskcrud.Services.Abstracts;

namespace taskcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(ICategoryServices _service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _service.GetAllAsync();
            return Ok(categories);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CategoryCreateDto dto)
        {
            await _service.CreateAsync(dto);
            return Created();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CategoryUpdateDto dto)
        {
            await _service.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
