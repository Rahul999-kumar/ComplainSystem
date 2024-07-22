using ComplainSystem.DomainModelCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.IServices
{
    public interface IUserProfileService
    {
        UserProfile NewUserProfileRegistration(UserProfile userModel);

        UserProfile GetUserProfileByID(Int32 userID);

        UserProfile UpdateUserProfile(UserProfile userModel);
    }
}
