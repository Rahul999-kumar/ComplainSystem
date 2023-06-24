using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class BaseEntities
    {
        public DateTime AddedOn { get; set; }
        public int AddedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int modifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string? IPAddress { get; set; }
    }
}
