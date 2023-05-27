namespace OBL.CSRM.Model
{
    public class ShiftAllInformation
    {
        //public string Sl { get; set; }
        //public string Name { get; set; }
        //public string Code { get; set; }
        //public bool IsActive { get; set; }
        //ShiftTimingID,ShiftName,ShiftCode
        public string EmployeeName { get; set; }
        public int EmployeeID { get; set; }
        public int ShiftTimingID { get; set; }
        public string ShiftName { get; set; }
        public int EmployeeShiftID { get; set; }
        public DateTime ShiftDate { get; set; }
        public string Gender { get; set; }



    }
}


