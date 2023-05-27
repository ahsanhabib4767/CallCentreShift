﻿using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class CfgService
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int ServiceType { get; set; }
        public string InstituteId { get; set; } = null!;
        public string? Note { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
