using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class UserRegistartion
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string? Token { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.Now;
        public Nullable<DateTime> LastLogin { get; set; }
        public string? IPAddress { get; set; }
    }
}
