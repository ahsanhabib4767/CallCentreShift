using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccCbsaccountHead
    {
        public int SysId { get; set; }
        public string AccountHeadId { get; set; } = null!;
        public string AccountHeadName { get; set; } = null!;
        public string AccountType { get; set; } = null!;
        public string? MapCmsaccountNumber { get; set; }
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
