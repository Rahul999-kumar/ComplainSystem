using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class TowerMaster 
    {
        [Key]
        public int TowerId { get; set; }
        [ForeignKey("SocietyMaster")]
        public int SocietyId { get; set; }
        public string TowerName { get; set; }
    }
}
