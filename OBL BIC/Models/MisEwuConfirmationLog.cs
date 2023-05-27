using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class MisEwuConfirmationLog
    {
        public int Id { get; set; }
        public string StudentId { get; set; } = null!;
        public string? StudentName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Semester { get; set; }
        public string CollectedAmount { get; set; } = null!;
        public DateTime CollectionDate { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
    }
}
