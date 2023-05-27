using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class SysScreenModule
    {
        public string ScreenId { get; set; } = null!;
        public string ModuleId { get; set; } = null!;
        public bool Status { get; set; }
    }
}
