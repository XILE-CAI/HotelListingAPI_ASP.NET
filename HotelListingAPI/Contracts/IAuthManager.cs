﻿using HotelListingAPI.Models.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListingAPI.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDTO userDTO);

        Task<AuthResponseDTO> Login(LoginDTO loginDTO);

        Task<string> CreateRefreshToken();
        Task<AuthResponseDTO> VerifyRefreshToken(AuthResponseDTO request);
    }
}
