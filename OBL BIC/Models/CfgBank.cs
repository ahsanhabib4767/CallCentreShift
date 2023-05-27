using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class CfgBank
    {
        public string Id { get; set; } = null!;
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? Note { get; set; }
        public string? CreatorUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifierUserId { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
