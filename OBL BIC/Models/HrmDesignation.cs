using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class HrmDesignation
    {
        public string Id { get; set; } = null!;
        public int? Sl { get; set; }
        public string ShortName { get; set; } = null!;
        public string? Name { get; set; }
        public string? Note { get; set; }
        public string CreatorUserId { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public string? ModifierUserId { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
