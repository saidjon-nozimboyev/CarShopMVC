using CarShop.Data.Entities;
using CarShop.Data.Interfaces;

namespace CarShop.Data.Repositories;

public class ImageRepository(AppDbContext dbContext)
    : Repository<Image>(dbContext), IImageInterface
{
}