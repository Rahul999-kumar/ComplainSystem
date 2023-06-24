using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class SocietyMaster
    {
        [Key]
        public int SocietyId { get; set; }
        public string SocietyName { get; set; }
    }
}
