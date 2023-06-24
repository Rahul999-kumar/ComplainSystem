using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class UserProfile
    {
        [Key]
        public int UserId { get; set; }
        public int RegistrationId { get; set; }
        public int Gender { get; set; }
        public DateTime DOB { get; set; }
        public int IdentityId { get; set; }
        public string IdentityNumber { get; set; } = string.Empty;
        public int DocumentId { get; set; }
        public string? SecondaryMobile { get; set; }
        public int SocietyId { get; set; }
        public int TowerId { get; set; }
        public int FloorId { get; set; }
        public int FlatId { get; set; }
    }
}
