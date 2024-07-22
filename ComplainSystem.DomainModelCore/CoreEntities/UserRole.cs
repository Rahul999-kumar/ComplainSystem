using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class UserRole
    {
        [Key]
        public int UserRoleID { get; set; }
        [ForeignKey("UserProfile")]
        public int UserID { get; set; }
        public int RoleID { get; set; }
    }
}
