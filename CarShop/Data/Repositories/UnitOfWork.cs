using CarShop.Data.Interfaces;

namespace CarShop.Data.Repositories;

public class UnitOfWork(AppDbContext dbContext)
    : IUnitOfWork
{
    public IBrandInterface Brands => new BrandRepository(dbContext);

    public ICarInterface Cars => new CarRepository(dbContext);

    public ICategoryInterface Categories => new CategoryRepository(dbContext);

    public IColorInterface Colors => throw new NotImplementedException();

    public IImageInterface Images => throw new NotImplementedException();

    public IOrderInterface Orders => throw new NotImplementedException();

    public IUserInterface Users => throw new NotImplementedException();
}
