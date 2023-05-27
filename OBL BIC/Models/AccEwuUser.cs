using System;
using System.Collections.Generic;

namespace OBL.BIC.Models
{
    public partial class AccEwuUser
    {
        public int Id { get; set; }
        public string? Employeename { get; set; }
        public string? Empbranchcode { get; set; }
        public string? Employeeid { get; set; }
        public string? Usertype { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
