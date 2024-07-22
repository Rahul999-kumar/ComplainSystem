using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class RoleMaster : BaseEntities
    {
        [Key]
        public int RoleId { get; set; }
        public string Rolename { get; set; }
    }
}
