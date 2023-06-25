using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.IRepositories
{
    /// <summary>
    /// This Application layer told us that what we are doing here only defination.
    /// It doest not care how he fetching the data
    /// </summary>
    public interface IUserRegistrationRepository
    {
        bool IsUserRegistered();
    }
}
