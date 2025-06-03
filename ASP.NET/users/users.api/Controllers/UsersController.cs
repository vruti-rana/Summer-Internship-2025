﻿using Microsoft.AspNetCore.Mvc;
using Users.Core.Interfaces;
using Users.Core.Models;

namespace Users.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService.GetUserAsync(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            await _userService.AddUserAsync(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
    }
}
