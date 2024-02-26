using CarShop.BusinessLogic.DTOs.CategoryDTOs;
using CarShop.Data.Entities;

namespace CarShop.BusinessLogic.DTOs.BrandDTOs
{
    public class BrandDto : CategoryDto
    {
        public static explicit operator BrandDto(Brand brand)
        => new()
        {
            Id = brand.Id,
            Name = brand.Name,
            ImagePath = brand.ImageUrl
        };
    }
}
