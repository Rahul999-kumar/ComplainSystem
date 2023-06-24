using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class UserIdentityMaster
    {
        [Key]
        public int IdentityId { get; set; }
        public string Name { get; set; }
    }
}
