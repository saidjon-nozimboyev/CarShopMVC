using CarShop.Areas.Admin.Data;
using CarShop.Areas.Admin.Data.Entities;
using CarShop.Areas.Admin.Data.Interfaces;

namespace CarShop.Areas.Admin.Data.Repositories;

public class CarRepository(AppDbContext dbContext)
    : Repository<Car>(dbContext), ICarInterface
{
    public List<Car> GetCarsWithRelations() => dbContext.Cars
            .Include(c => c.Category)
            .Include(c => c.Brand)
            .ToList();

}
