using ComplainSystem.Application.IRepositories;
using ComplainSystem.Application.IServices;
using ComplainSystem.DomainModelCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.Application.Repositories
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository _userProfileRepository;
        //Constructor Depencency
        public UserProfileService(IUserProfileRepository userProfileRepository) {
            _userProfileRepository = userProfileRepository;
        }
        public UserProfile GetUserProfileByID(Int32 userID)
        {
           return _userProfileRepository.GetUserProfileByID(userID);
        }

        public UserProfile NewUserProfileRegistration(UserProfile userProfile)
        {
            return _userProfileRepository.NewUserProfileRegistration(userProfile); ;
        }

        public UserProfile UpdateUserProfile(UserProfile userProfile)
        {
            return _userProfileRepository.UpdateUserProfile(userProfile);
        }
    }
}
