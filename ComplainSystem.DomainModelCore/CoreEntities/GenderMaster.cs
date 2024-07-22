using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class GenderMaster
    {
        [Key]
        public int GenderID { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
    }
}
