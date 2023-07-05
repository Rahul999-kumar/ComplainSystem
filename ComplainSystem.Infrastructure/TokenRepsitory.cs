using ComplainSystem.Application.BusinessModels;
using ComplainSystem.Application.IRepositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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
            var userData = _csDbContext.UserRegistration.Any(x => x.Username == userLogin.username && x.Password == userLogin.password);
            if (!userData)
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
                    new Claim(ClaimTypes.Name, userLogin.username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(20),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandelr.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandelr.WriteToken(token) };
        }
    }
}
