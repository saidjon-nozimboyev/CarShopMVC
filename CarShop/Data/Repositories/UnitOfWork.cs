using CarShop.Data.Interfaces;

namespace CarShop.Data.Repositories;

public class UnitOfWork(AppDbContext dbContext)
    : IUnitOfWork
{
    public IBrandInterface Brands => new BrandRepository(dbContext);

    public ICarInterface Cars => new CarRepository(dbContext);

    public ICategoryInterface Categories => new CategoryRepository(dbContext);

    public IColorInterface Colors => new ColorRepository(dbContext);

    public IImageInterface Images => new ImageRepository(dbContext);

    public IOrderInterface Orders => new OrderRepository(dbContext);

    public IUserInterface Users => new UserRepository(dbContext);
}
