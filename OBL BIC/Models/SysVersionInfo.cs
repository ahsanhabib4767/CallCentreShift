using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class SysVersionInfo
    {
        public int SysId { get; set; }
        public string AppVersion { get; set; } = null!;
        public string Dbversion { get; set; } = null!;
        public long Version { get; set; }
        public DateTime? AppliedOn { get; set; }
        public string? Description { get; set; }
        public string? UpdateMessage { get; set; }
        public string? TerminalMessage { get; set; }
    }
}
