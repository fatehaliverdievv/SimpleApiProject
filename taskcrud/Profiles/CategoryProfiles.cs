namespace taskcrud.Profiles;
using AutoMapper;
using taskcrud.DTOs.Categories;
using taskcrud.Entities;
public class CategoryProfiles:Profile
 {
     public CategoryProfiles()
     {
         CreateMap<CategoryCreateDto,Category>();
        CreateMap<Category, CategoryGetDto>();
    }
 }
