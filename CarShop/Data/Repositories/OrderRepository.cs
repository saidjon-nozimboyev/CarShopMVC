using CarShop.Data.Entities;
using CarShop.Data.Interfaces;

namespace CarShop.Data.Repositories;

public class OrderRepository(AppDbContext dbContext)
    : Repository<Order>(dbContext), IOrderInterface
{
}
