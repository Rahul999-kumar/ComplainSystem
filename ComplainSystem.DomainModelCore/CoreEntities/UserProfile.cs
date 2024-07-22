using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class UserProfile
    {
        [Key]
        public int UserProfileId { get; set; }
        [ForeignKey("UserRegistartion")]
        public int UserID { get; set; }
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [ForeignKey("GenderMaster")]
        public int GenderID { get; set; }
        public Nullable<DateTime> DOB { get; set; }
        [StringLength(10)]
        public string? Mobile { get; set; }
        public string? AlternateMobile { get; set; }
        public Nullable<DateTime> AddedOn { get; set; }
        public int AddedBy { get; set; }
        public Nullable<DateTime> ModifiedOn { get; set; }
        public int ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string? IPAddress { get; set; }
    }
}
