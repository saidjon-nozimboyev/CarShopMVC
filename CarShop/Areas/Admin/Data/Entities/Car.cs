namespace CarShop.Areas.Admin.Data.Entities;

public class Car : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();
    public int BrandId { get; set; }
    public Brand Brand { get; set; } = new();

    public List<Color> Colors { get; set; } = new();
    public List<Order> Images { get; set; } = new();

}
