using ComplainSystem.Application.IRepositories;
using ComplainSystem.DomainModelCore.CoreEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplainSystem_Utility;

namespace ComplainSystem.Infrastructure
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly CSDbContext _csDbContext;

        public UserProfileRepository(CSDbContext csDbContext)
        {
            _csDbContext = csDbContext;
        }
        public UserProfile GetUserProfileByID(Int32 userID)
        {
            var profileData = _csDbContext.UserProfile.Where(x => x.UserID == userID).SingleOrDefault() ?? null;
            if (profileData == null)
            {
                profileData = null;
            }
            return profileData;
        }

        public UserProfile NewUserProfileRegistration(UserProfile userProfileModel)
        {
            try
            {
                _csDbContext.UserProfile.Add(userProfileModel);
                _csDbContext.SaveChanges();
            }

            catch (Exception)
            {

                _csDbContext.Database.RollbackTransaction();
            }
            //}
            return userProfileModel;
        }

        public UserProfile UpdateUserProfile(UserProfile userModel)
        {
            using (var dbContextTransaction = _csDbContext.Database.BeginTransaction())
            {
                try
                {
                    var userData = _csDbContext.UserProfile.Where(x => x.UserID == userModel.UserID).SingleOrDefault();
                    userData.FirstName = userModel.FirstName;
                    userData.LastName = userModel.LastName;
                    userData.Mobile = userModel.Mobile;
                    userData.AlternateMobile = userModel.AlternateMobile;
                    userData.DOB = userModel.DOB;
                    userData.ModifiedOn = DateTime.Now;
                    userData.IsActive = true;
                    userData.ModifiedOn = DateTime.Now;
                    userData.ModifiedBy = userModel.UserID;
                    userData.GenderID = userModel.GenderID;
                    userData.IPAddress = GetIPAddress.GenerateIPAddress();
                    _csDbContext.SaveChanges();
                    dbContextTransaction.Commit();
                }
                catch (Exception) 
                { 
                    _csDbContext.Database.RollbackTransaction(); 
                }

              
            }
            return userModel;
        }
    }
}
