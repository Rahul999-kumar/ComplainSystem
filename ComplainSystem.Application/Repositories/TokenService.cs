using ComplainSystem.Application.BusinessModels;
using ComplainSystem.Application.IRepositories;
using ComplainSystem.Application.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.Repositories
{
    public class TokenService : ITokenService
    {
        private readonly ITokenRepository _tokenRepository;
        public TokenService(ITokenRepository tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }
        public Tokens Authenticate(UserLogin userLogin)
        {
            return _tokenRepository.Authenticate(userLogin);
        }
    }
}
