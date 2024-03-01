using CarShop.Areas.Admin.Data;
using CarShop.Areas.Admin.Data.Entities;
using CarShop.Areas.Admin.Data.Interfaces;

namespace CarShop.Areas.Admin.Data.Repositories;

public class ImageRepository(AppDbContext dbContext)
    : Repository<Image>(dbContext), IImageInterface
{
}