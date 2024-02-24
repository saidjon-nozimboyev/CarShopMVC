using CarShop.Data.Interfaces;
using System.Drawing;

namespace CarShop.Data.Repositories;

public class ColorRepository(AppDbContext dbContext)
    : Repository<Color>(dbContext), IColorInterface
{
}
