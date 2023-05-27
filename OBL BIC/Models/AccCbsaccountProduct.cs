using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccCbsaccountProduct
    {
        public int Id { get; set; }
        public int? Sl { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int AccountTypeId { get; set; }
        public string? Note { get; set; }
    }
}
