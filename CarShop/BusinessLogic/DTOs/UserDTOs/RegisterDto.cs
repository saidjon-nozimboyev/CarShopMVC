﻿namespace CarShop.BusinessLogic.DTOs.UserDTOs;

public class RegisterDto
{
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }

    public string? ErrorMessage { get; set; }
}
