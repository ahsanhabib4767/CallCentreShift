using System;
using System.Collections.Generic;

namespace OBL.BIC.Model
{
    public partial class NonWorkingDay
    {
        public int NonWorkingDayId { get; set; }
        public DateTime? NonWorkingDate { get; set; }
        public string? HoliDayName { get; set; }
    }
}
