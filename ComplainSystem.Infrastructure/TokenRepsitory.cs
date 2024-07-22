using ComplainSystem.Application.BusinessModels;
using ComplainSystem.Application.IRepositories;
using ComplainSystem.DomainModelCore.CoreEntities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ComplainSystem.Infrastructure
{
    public class TokenRepsitory : ITokenRepository
    {
        private readonly CSDbContext _csDbContext;
        private readonly IConfiguration _configuration;
        public TokenRepsitory(CSDbContext csDbContext, IConfiguration configuration)
        {
            _csDbContext = csDbContext;
            _configuration = configuration;
        }
        public Tokens Authenticate(UserLogin userLogin)
        {
            var userData = _csDbContext.UserRegistration.Where(x => x.Username == userLogin.username && x.Password == userLogin.password).FirstOrDefault();
            //var userData = _csDbContext.UserRegistration.Any(x => x.Username == userLogin.username && x.Password == userLogin.password);
            if (userData == null)
            {
                return null;
            }

            //Yup We have authenticated

            //Here we are creating JWT(Json Web Token)
            var tokenHandelr = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userLogin.username),
                    new Claim(ClaimTypes.SerialNumber, Convert.ToString(userData.UserID)),
                    new Claim(ClaimTypes.Role, "User")
                }),

                Expires = DateTime.UtcNow.AddMinutes(20),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
                //Audience = _configuration["Jwt:Audience"],
                //Issuer = _configuration["Jwt:Issuer"]
            };
            var token = tokenHandelr.CreateToken(tokenDescriptor);
            //var refreshToken = GenerateRefreshToken();
            return new Tokens
            {
                Token = tokenHandelr.WriteToken(token)
                //,RefreshToken = refreshToken
            };
        }

        private static string GenerateRefreshToken()
        {
            var tokenBytes = RandomNumberGenerator.GetBytes(64);
            var refreshToken = Convert.ToBase64String(tokenBytes);
            return refreshToken;
        }
    }
}
