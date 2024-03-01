using CarShop.Areas.Admin.Data;
using CarShop.Areas.Admin.Data.Entities;
using CarShop.Areas.Admin.Data.Interfaces;

namespace CarShop.Areas.Admin.Data.Repositories;

public class CategoryRepository(AppDbContext dbContext)
    : Repository<Category>(dbContext), ICategoryInterface
{
}
