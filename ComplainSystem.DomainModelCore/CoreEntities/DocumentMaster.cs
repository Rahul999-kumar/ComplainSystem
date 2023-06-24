using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainSystem.DomainModelCore.CoreEntities
{
    public class DocumentMaster
    {
        [Key]
        public int DocumentId { get; set; }
        public int UserId { get; set; }
        public string PhotoPath { get; set; } = string.Empty;
    }
}
