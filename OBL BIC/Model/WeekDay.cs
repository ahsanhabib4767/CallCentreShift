using System;
using System.Collections.Generic;

namespace OBL.BIC.Model
{
    public partial class WeekDay
    {
        public int WeekId { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public DateTime? WeekEndTime { get; set; }
    }
}
