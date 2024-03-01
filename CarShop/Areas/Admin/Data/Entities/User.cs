namespace CarShop.Areas.Admin.Data.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string PhoneNum { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Address { get; set; } = null!;
    public Role Role { get; set; } = Role.User;
    public List<Order> Orders { get; set; } = new();

}
public enum Role
{
    Admin,
    User
}