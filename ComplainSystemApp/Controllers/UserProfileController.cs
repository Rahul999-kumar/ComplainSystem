using ComplainSystem.Application.IServices;
using ComplainSystem.Application.Repositories;
using ComplainSystem.DomainModelCore.CoreEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComplainSystemApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;
        public UserProfileController(IUserProfileService UserProfileService)
        {
            _userProfileService = UserProfileService;
        }

        [HttpGet("GetUserProfileByID/{userID}")]
        public IActionResult GetUserProfileByID(Int32 userID)
        {
            var profileData = _userProfileService.GetUserProfileByID(userID);
            return profileData == null ? NotFound() : Ok(profileData);
        }

        [HttpPut("UpdateUserProfile")]
        public IActionResult UpdateProfile(UserProfile userProfileModel)
        {

            var data = _userProfileService.UpdateUserProfile(userProfileModel);
            if (data != null)
            {
               userProfileModel = _userProfileService.GetUserProfileByID(data.UserProfileId);
            }
            return Ok(userProfileModel);

        }
    }
}
