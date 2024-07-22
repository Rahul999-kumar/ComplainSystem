using ComplainSystem.DomainModelCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.IRepositories
{
    public interface IUserProfileRepository
    {
        UserProfile NewUserProfileRegistration(UserProfile userProfileModel);

        UserProfile GetUserProfileByID(Int32 userID);

        UserProfile UpdateUserProfile(UserProfile userModel);
    }
}
