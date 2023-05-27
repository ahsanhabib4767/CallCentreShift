using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccCbsaccountType
    {
        public int Id { get; set; }
        public int CbstypeId { get; set; }
        public int? Sl { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string? Note { get; set; }
    }
}
