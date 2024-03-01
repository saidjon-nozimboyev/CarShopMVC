using AutoMapper;
using CarShop.Areas.Admin.Data.Entities;
using CarShop.BusinessLogic.DTOs.BrandDTOs;

namespace CarShop.BusinessLogic.Common
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Brand, BrandDto>()
                .ForMember(dest => dest.ImagePath, opt => opt.MapFrom(src => src.ImageUrl))
                .ReverseMap();
        }
    }
}
