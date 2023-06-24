using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    internal class TowerMaster
    {
        [Key]
        public int TowerId { get; set; }
        public int SocietyId { get; set; }
        public string TowerName { get; set; }
    }
}
