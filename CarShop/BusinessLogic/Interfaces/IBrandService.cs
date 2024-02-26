using CarShop.BusinessLogic.DTOs.BrandDTOs;

namespace CarShop.BusinessLogic.Interfaces;

public interface IBrandService
{
    List<BrandDto> GetAll();
    BrandDto GetById(int id);
    void Create(AddBrandDto brendDto);
    void Update(UpdateBrandDto brendDto);
    void Delete(int id);
}
