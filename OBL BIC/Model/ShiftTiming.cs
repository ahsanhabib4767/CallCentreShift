using System;
using System.Collections.Generic;

namespace OBL.BIC.Model
{
    public partial class ShiftTiming
    {
        public ShiftTiming()
        {
            EmployeeShifts = new HashSet<EmployeeShift>();
        }

        public int ShiftTimingId { get; set; }
        public TimeSpan? ShiftStartTime { get; set; }
        public TimeSpan? ShiftEndTime { get; set; }
        public string? ShiftName { get; set; }
        public string? ShiftCode { get; set; }

        public virtual ICollection<EmployeeShift> EmployeeShifts { get; set; }
    }
}
