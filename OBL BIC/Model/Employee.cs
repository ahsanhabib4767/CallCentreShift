using System;
using System.Collections.Generic;

namespace OBL.BIC.Model
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeShifts = new HashSet<EmployeeShift>();
        }

        public int EmployeeId { get; set; }
        public string? EmpIdentity { get; set; }
        public string? EmployeeName { get; set; }
        public int? ManagerId { get; set; }
        public string? Gender { get; set; }

        public string? Usertype { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        
        public bool? IsActive { get; set; }

        public virtual Manager? Manager { get; set; }
        public virtual ICollection<EmployeeShift> EmployeeShifts { get; set; }
    }
}
