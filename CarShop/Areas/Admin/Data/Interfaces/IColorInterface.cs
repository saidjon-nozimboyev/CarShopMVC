using CarShop.Areas.Admin.Data.Entities;

namespace CarShop.Areas.Admin.Data.Interfaces;

public interface IColorInterface : IRepository<Color>
{
    Color GetByIdWithImages(int id);
}
