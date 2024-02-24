using CarShop.Data.Entities;
using CarShop.Data.Interfaces;

namespace CarShop.Data.Repositories;

public class BrandRepository(AppDbContext dbContext) : Repository<Brand>(dbContext), IBrandInterface
{
    public void Add(Brand entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAll()
    {
        throw new NotImplementedException();
    }

    public Brand GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Brand entity)
    {
        throw new NotImplementedException();
    }
}
