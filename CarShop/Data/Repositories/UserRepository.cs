using CarShop.Data.Entities;
using CarShop.Data.Interfaces;

namespace CarShop.Data.Repositories;

public class UserRepository(AppDbContext dbContext)
    : Repository<User>(dbContext), IUserInterface
{
}
