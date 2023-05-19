﻿using Classify.Service.DTOs.LoginDto;
using Classify.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FleetFlow.Api.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync(LoginDto dto)
        {
            return Ok(await this.authService.AuthenticateAsync(dto.Email, dto.Password));
        }
    }
}
