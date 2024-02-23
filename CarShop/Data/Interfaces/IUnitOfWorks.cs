namespace CarShop.Data.Interfaces;

public interface IUnitOfWorks
{
    IBrandInterface Brands { get; }
    ICarInterface Cars { get; }
    ICategoryInterface Categories { get; }
    IColorInterface Colors { get; }
    IImageInterface Images { get; }
    IOrderInterface Orders { get; }
    IUserInterface Users { get; }
}
