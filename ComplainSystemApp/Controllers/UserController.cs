using ComplainSystem.Application.IServices;
using ComplainSystem.Application.Repositories;
using ComplainSystem.DomainModelCore.CoreEntities;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComplainSystemApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRegistrationService _userService;

        public UserController(IUserRegistrationService userService)
        {
            _userService = userService;
          
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserRegistartion> Get()
        {
            //_userService.IsUserRegistered();
            return _userService.GetAllRegisteredUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost("NewUser")]
        public ActionResult NewUser(UserRegistartion dataModel)
        {
            if (dataModel != null)
            {
                var data = _userService.NewUserRegistration(dataModel);
                return Ok(data);
            }
            return Ok();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
