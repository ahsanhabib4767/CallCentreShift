using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class CfgInstitute
    {
        public string Id { get; set; } = null!;
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? Note { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
