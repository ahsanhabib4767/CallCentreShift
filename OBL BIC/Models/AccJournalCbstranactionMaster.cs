using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccJournalCbstranactionMaster
    {
        public string SysId { get; set; } = null!;
        public decimal TransId { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime ExecutionDate { get; set; }
        public int TotalTxnCount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? JournalType { get; set; }
        public string? JobProcessUser { get; set; }
        public string? AuthorizerUser { get; set; }
        public string? Narration { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string IsPosted { get; set; } = null!;
    }
}
