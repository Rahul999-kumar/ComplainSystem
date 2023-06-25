using ComplainSystem.Application.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Infrastructure
{
    /// <summary>
    /// This Infrastructure Layer is actualy have the full implementation and login how we are communication with databse.
    /// 
    /// </summary>
    public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private readonly CSDbContext _csDbContext;

        public UserRegistrationRepository(CSDbContext csDbContext)
        {
            _csDbContext = csDbContext;
        }
        public bool IsUserRegistered()
        {
            return true;
        }
    }
}
