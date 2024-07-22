using ComplainSystem.Application.IRepositories;
using ComplainSystem.DomainModelCore.CoreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace ComplainSystem.Infrastructure
{
    /// <summary>
    /// This Infrastructure Layer is actualy have the full implementation and login how we are communication with databse.
    /// 
    /// </summary>
    public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private readonly CSDbContext _csDbContext;
        private readonly UserProfileRepository _IUserProfileRepository;

        public UserRegistrationRepository(CSDbContext csDbContext)
        {
            _csDbContext = csDbContext;
            _IUserProfileRepository = new UserProfileRepository(csDbContext);
        }


        public List<UserRegistartion> GetAllRegisteredUsers()
        {
            return _csDbContext.UserRegistration.ToList();
        }

        [Obsolete]
        public UserRegistartion NewUserRegistration(UserRegistartion userModel)
        {
            
            using (var dbContextTransaction = _csDbContext.Database.BeginTransaction())
            {
                try
                {
                    var userDetails = CheckIfUserExists(userModel);
                    if (userDetails == null)
                    {
                        // Get the Name of HOST   
                        string hostName = Dns.GetHostName();

                        // Get the IP from GetHostByName method of dns class.
                        string IP = Dns.GetHostByName(hostName).AddressList.Last().ToString();

                        userModel.IPAddress = IP;
                        userModel.AddedOn = DateTime.Now;
                        _csDbContext.UserRegistration.Add(userModel);
                        UserProfile profile = new UserProfile();
                        _csDbContext.SaveChanges();

                        //Add RegistrationID in Userprofile Table
                        profile.UserID = userModel.UserID;
                        profile.IPAddress = IP;
                        profile.IsActive = true;
                        profile.AddedOn = DateTime.Now;
                        _IUserProfileRepository.NewUserProfileRegistration(profile);

                        dbContextTransaction.Commit();
                    }
                    else
                    {
                        userDetails.Username = "exists";
                        userModel = userDetails;
                    }
                }

                catch (Exception)
                {

                    _csDbContext.Database.RollbackTransaction();
                }
            }
            return userModel;

        }

        private UserRegistartion CheckIfUserExists(UserRegistartion model)
        {
            var userDetails = _csDbContext.UserRegistration.Where(x => x.Username == model.Username).FirstOrDefault();
            if (userDetails != null && userDetails.UserID != 0)
            {
                return userDetails;
            }
            else
            {
                return userDetails;
            }
        }
    }
}

