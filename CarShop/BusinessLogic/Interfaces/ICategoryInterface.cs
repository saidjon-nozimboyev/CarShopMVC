using CarShop.BusinessLogic.DTOs.CategoryDTOs;

namespace CarShop.BusinessLogic.Interfaces;

public interface ICategoryInterface
{
    List<CategoryDto> GetAll();
    CategoryDto GetById(int id);
    void Create(AddCategoryDto categoryDto);
    void Update(UpdateCategoryDto categoryDto);
    void Delete(int id);
}
