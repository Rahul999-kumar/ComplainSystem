using ComplainSystem.Application.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.IServices
{
    public interface ITokenService
    {
        Tokens Authenticate(UserLogin userLogin);
    }
}
