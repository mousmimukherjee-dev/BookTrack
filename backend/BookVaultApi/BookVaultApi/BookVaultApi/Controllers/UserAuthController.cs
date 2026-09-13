using System.Drawing.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BookVaultApi.Data;
using BookVaultApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BookVaultApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly string? _jwtKey;
        private readonly string? _JwtIssuer;
        private readonly string? _jwtAudience;
        private readonly int _jwtExpiry;

        public UserAuthController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signinManager,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signinManager = signinManager;
            _jwtKey = configuration["Jwt:Key"];
            _JwtIssuer = configuration["Jwt:Issuer"];
            _jwtAudience = configuration["Jwt:Audience"];
            _jwtExpiry = int.Parse(configuration["Jwt:ExpiryMinutes"]);

        }

        [HttpPost("register")]

        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {
            if (registerModel == null
                || string.IsNullOrEmpty(registerModel.Name)
                || string.IsNullOrEmpty(registerModel.Password)
                || string.IsNullOrEmpty(registerModel.Email))
            {
                return BadRequest("Invalid Registration Deatils");
            }

            var existingUser = await _userManager.FindByEmailAsync(registerModel.Email);

            if (existingUser != null)
            {

                return Conflict("Email already Exist");
            }

            var user = new ApplicationUser
            {
                UserName = registerModel.Name,
                Email = registerModel.Email,
                Name = registerModel.Name,
            };

            var result = await _userManager.CreateAsync(user, registerModel.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            return Ok("User Created Successfully");
        }

        [HttpPost("login")]

        public async Task<IActionResult> Login([FromBody] LoginModel loginmodel)
        {
            var user = await _userManager.FindByEmailAsync(loginmodel.Email);

            if (user == null)
            {

                return Unauthorized(new { success = false, message = "Inavalid username or password" });


            }

            var result = await _signinManager.CheckPasswordSignInAsync(user, loginmodel.Password, false);

            if (!result.Succeeded)
            {
                return Unauthorized(new { success = false, message = "Invalid username or password" });
            }

            var token = GenerateJWTToken(user);

            return Ok(new { success = true, token });
        }


        [HttpPost("logout")]

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return Ok("User Logged out Successfully");
        }


            private string GenerateJWTToken(ApplicationUser user)
            {
            var Claims = new[]

            {
                    new Claim(JwtRegisteredClaimNames.Sub , user.Id),
                    new Claim(JwtRegisteredClaimNames.Email , user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString()),
                     new Claim("Name" , user.Name),


                };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: Claims,
                expires: DateTime.Now.AddMinutes(_jwtExpiry),
                signingCredentials: creds);


            return new JwtSecurityTokenHandler().WriteToken(token);

            }



        }


    }

