using CarShop.Areas.Admin.Data.Entities;
using CarShop.BusinessLogic.DTOs.BrandDTOs;
using CarShop.BusinessLogic.DTOs.CarDTOs;
using CarShop.BusinessLogic.DTOs.CategoryDTOs;
using CarShop.BusinessLogic.DTOs.ColorDTOs;

namespace CarShop.BusinessLogic.Common;

public static class Mapper
{
    public static CarDto ToCarDto(this Car car)
        => new()
        {
            Id = car.Id,
            Name = car.Name,
            Description = car.Description,
            Price = car.Price,
            Category = (CategoryDto)car.Category,
            Brand = (BrandDto)car.Brand,
            Colors = car.Colors.Select(c => (ColorDto)c).ToList()
        };
}
