using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class UserRegistartion
    {
        [Key]
        public int UserRegistrationId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string? MobileNo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Token { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
