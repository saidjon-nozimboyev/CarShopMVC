namespace CarShop.BusinessLogic.Common;

public class CustomException(string key, string message) 
    : Exception(message)
{
    public string Key { get; set; } = key;
}
