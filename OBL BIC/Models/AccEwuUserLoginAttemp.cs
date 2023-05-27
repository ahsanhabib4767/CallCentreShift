using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccEwuUserLoginAttemp
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int? LoginAttemps { get; set; }
    }
}
