using OBL.BIC.Model;
using OBL.CSRM.Model;
using System.Data;

namespace OBL.CSRM.IRepository
{
    public interface IRepositoryDependency
    {
        List<DynamicData> GetItemsByType(string data);
        List<ShiftAllInformation> GetAllShiftInformation(string itemType);

        List<ShiftAllInformation> GetAllShiftInformationByID(string itemType, int empid);

        DataTable GetAllShiftCount();

        List<ShiftTimingDropDown> GetAllShiftDropdownInformationByDate(DateTime itemtype);

        string InsertDataIntoDB(int employeeId1, int employeeId2, DateTime dropDownInfo);
    }
}
