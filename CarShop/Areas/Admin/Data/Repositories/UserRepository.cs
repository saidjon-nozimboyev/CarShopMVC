using CarShop.Areas.Admin.Data;
using CarShop.Areas.Admin.Data.Entities;
using CarShop.Areas.Admin.Data.Interfaces;

namespace CarShop.Areas.Admin.Data.Repositories;

public class UserRepository(AppDbContext dbContext)
    : Repository<User>(dbContext), IUserInterface
{
}
