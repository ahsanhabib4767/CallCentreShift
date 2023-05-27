using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class SysModule
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool Status { get; set; }
        public string? Creator { get; set; }
        public DateTime? Creationdate { get; set; }
        public string? Modifier { get; set; }
        public DateTime? Modificationdate { get; set; }
    }
}
