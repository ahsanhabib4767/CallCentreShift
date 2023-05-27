using System;
using System.Collections.Generic;

namespace OBL.BIC.Model
{
    public partial class EmployeeShift
    {
        public int EmployeeShiftId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ShiftTimingId { get; set; }
        public DateTime? ShiftDate { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual ShiftTiming? ShiftTiming { get; set; }
    }
}
