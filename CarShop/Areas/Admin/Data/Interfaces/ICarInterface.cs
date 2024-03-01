using CarShop.Areas.Admin.Data.Entities;

namespace CarShop.Areas.Admin.Data.Interfaces;

public interface ICarInterface : IRepository<Car>
{
    List<Car> GetCarsWithRelations();
}
