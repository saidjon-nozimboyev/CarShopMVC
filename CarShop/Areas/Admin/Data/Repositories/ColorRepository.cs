using CarShop.Areas.Admin.Data.Entities;
using CarShop.Areas.Admin.Data.Interfaces;

namespace CarShop.Areas.Admin.Data.Repositories;

public class ColorRepository(AppDbContext dbContext)
    : Repository<Color>(dbContext), IColorInterface
{
    public Color GetByIdWithImages(int id)
        => dbContext.Colors
            .Include(c => c.Images)
            .Include(x => x.Car)
            .FirstOrDefault(c => c.Id == id);
}