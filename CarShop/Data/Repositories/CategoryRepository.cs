using CarShop.BusinessLogic.Interfaces;
using CarShop.Data.Entities;

namespace CarShop.Data.Repositories;

public class CategoryRepository(AppDbContext dbContext)
    : Repository<Category>(dbContext), ICategoryInterface
{
}
