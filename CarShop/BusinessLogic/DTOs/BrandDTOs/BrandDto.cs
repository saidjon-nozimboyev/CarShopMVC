using CarShop.Areas.Admin.Data.Entities;
using CarShop.BusinessLogic.DTOs.CategoryDTOs;

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
