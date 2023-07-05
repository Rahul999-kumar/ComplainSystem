using ComplainSystem.Application.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.IRepositories
{
    public interface ITokenRepository
    {
        Tokens Authenticate(UserLogin userLogin); 
    }
}
