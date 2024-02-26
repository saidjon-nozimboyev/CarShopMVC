using CarShop.BusinessLogic.DTOs.BrandDTOs;
using CarShop.BusinessLogic.DTOs.CategoryDTOs;

namespace CarShop.BusinessLogic.DTOs.CarDTOs;

public class AddCarDto
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public int BrendId { get; set; }

    public List<CategoryDto> Categories { get; set; } = new();
    public List<BrandDto> Brands { get; set; } = new();
}
