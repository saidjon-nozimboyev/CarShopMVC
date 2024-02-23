using CarShop.Data.Entities;

namespace CarShop.Data.Interfaces;

public interface ICarInterface : IRepository<Car>
{
    List<Car> GetCarsWithRelations();
}
