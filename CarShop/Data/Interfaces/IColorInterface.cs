using CarShop.Data.Entities;

namespace CarShop.Data.Interfaces;

public interface IColorInterface : IRepository<Color>
{
    Color GetByIdWithImages(int id);
}
