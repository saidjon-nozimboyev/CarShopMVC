using AutoMapper;
using CarShop.BusinessLogic.DTOs.BrandDTOs;
using CarShop.Data.Entities;

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
