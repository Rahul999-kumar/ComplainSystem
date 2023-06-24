using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class FloorMaster
    {
        [Key]
        public int FloorId { get; set; }
        public int SocietyId { get; set; }
        public int TowerId { get; set; }
        public int FloorNo { get; set; }
    }
}
