using System;
using System.Collections.Generic;

namespace OBL.BIC.Model
{
    public partial class Manager
    {
        public Manager()
        {
            Employees = new HashSet<Employee>();
        }

        public int ManagerId { get; set; }
        public string? ManagerName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
