using CarShop.Data.Entities;
using CarShop.Data.Interfaces;
namespace CarShop.Data.Repositories;

public class CarRepository(AppDbContext dbContext)
    : Repository<Car>(dbContext), ICarInterface
{
    public List<Car> GetCarsWithRelations() => dbContext.Cars
            .Include(c => c.Category)
            .Include(c => c.Brend)
            .ToList();

}
