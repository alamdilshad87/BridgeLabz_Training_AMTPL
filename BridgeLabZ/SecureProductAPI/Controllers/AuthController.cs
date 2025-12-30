using Microsoft.AspNetCore.Mvc;
using SecureProductAPI.Data;
using SecureProductAPI.DTOs;
using SecureProductAPI.Models;
using SecureProductAPI.Security;
using SecureProductAPI.Services.Interfaces;

namespace SecureProductAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IJwtService _jwt;

        public AuthController(AppDbContext context, IJwtService jwt)
        {
            _context = context;
            _jwt = jwt;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            var user = new User
            {
                Username = dto.Username,
                PasswordHash = PasswordHasher.Hash(dto.Password),
                Role = "User"
            };

            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("User Registered");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var hash = PasswordHasher.Hash(dto.Password);
            var user = _context.Users
                .FirstOrDefault(x => x.Username == dto.Username && x.PasswordHash == hash);

            if (user == null) return Unauthorized();

            var token = _jwt.GenerateToken(user.Username, user.Role);
            return Ok(token);
        }
    }
}
