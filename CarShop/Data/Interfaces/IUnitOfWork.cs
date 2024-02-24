namespace CarShop.Data.Interfaces;

public interface IUnitOfWork
{
    IBrandInterface Brands { get; }
    ICarInterface Cars { get; }
    ICategoryInterface Categories { get; }
    IColorInterface Colors { get; }
    IImageInterface Images { get; }
    IOrderInterface Orders { get; }
    IUserInterface Users { get; }
}
