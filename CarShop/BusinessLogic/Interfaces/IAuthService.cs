﻿using CarShop.Areas.Admin.Data.Entities;
using CarShop.BusinessLogic.DTOs.UserDTOs;
using System.Data;

namespace CarShop.BusinessLogic.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResult> LoginAsync(LoginDto loginDto, Role kim);
        AuthResult CreateUser(RegisterDto registerDto);
        bool IsLoggedIn();
        void Logout(Role kim);
        string GetFullName(Role kim);
        string GetPhoneNumber(Role kim);
    }
}
