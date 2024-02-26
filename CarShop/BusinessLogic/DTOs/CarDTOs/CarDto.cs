using CarShop.BusinessLogic.DTOs.BrandDTOs;
using CarShop.BusinessLogic.DTOs.CategoryDTOs;
using CarShop.BusinessLogic.DTOs.ColorDTOs;

namespace CarShop.BusinessLogic.DTOs.CarDTOs;

public class CarDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public CategoryDto Category { get; set; } = new();
    public BrandDto Brend { get; set; } = new();

    public List<ColorDto> Colors { get; set; } = new();
}
