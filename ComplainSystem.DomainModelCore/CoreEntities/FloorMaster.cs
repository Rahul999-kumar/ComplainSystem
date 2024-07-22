using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class FloorMaster
    {
        [Key]
        public int FloorId { get; set; }
        [ForeignKey("SocietyMaster")]
        public int SocietyId { get; set; }
        [ForeignKey("TowerMaster")]
        public int TowerId { get; set; }
        public int FloorNo { get; set; }
    }
}
