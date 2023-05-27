using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class SysScreen
    {
        public string Id { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string MenuName { get; set; } = null!;
        public string ViewObjectName { get; set; } = null!;
        public string? MenuIconObjectPath { get; set; }
        public int? DisplaySl { get; set; }
        public int? IsGroup { get; set; }
        public string Creator { get; set; } = null!;
        public DateTime Creationdate { get; set; }
        public string? Modifier { get; set; }
        public DateTime? Modificationdate { get; set; }
    }
}
