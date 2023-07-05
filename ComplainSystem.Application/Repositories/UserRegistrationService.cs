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
    public class UserRegistrationService : IUserRegistrationService
    {
        private readonly IUserRegistrationRepository _userRepository;

        ///UserRegistarionService implement IUserRegistrationService interface and implement use case and 
        ///instead of IUserRegistrationService going itself to the database to fetch the data from the database
        ///it has deligated an interfaceto do that it's on behalf
        ///And how we are getting or inserting the data we don't know and we don't care
        ///and thats where the Clean Architecture paradigm comes into its full fold here

        //Constructor Dependency Injection

        public UserRegistrationService(IUserRegistrationRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserRegistartion> GetAllRegisteredUsers()
        {
            return _userRepository.GetAllRegisteredUsers();
        }

        public UserRegistartion NewUserRegistration(UserRegistartion userModel)
        {
            return _userRepository.NewUserRegistration(userModel);
        }
    }
}
