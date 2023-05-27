using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
//using OBL.BIC.Models;
//using OBL.BIC.Models;
using OBL.BIC.Data;
using OBL.BIC.Entity;
using OBL.BIC.Gateway;
using OBL.BIC.Model;
using OBL.BIC.Models;
using OBL.CSRM.IRepository;
using OBL.CSRM.Model;
using System.Text;

namespace OBL.BIC.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        private ApplicationDbContext _db;
        private TestContext _db2;
        private IConfiguration _configuration;
        private readonly IRepositoryDependency _dataRepository;
        public TransactionController(ApplicationDbContext db, TestContext db2, IConfiguration iconfig, IRepositoryDependency dataRepository)
        {
            _db = db;
            _db2 = db2;
            _configuration = iconfig;
            _dataRepository = dataRepository;
        }
        #region ***Methods***
        /// <summary>
        /// BIC Bill Collection System
        /// By : Ahsan_2023
        /// </summary>
        /// <returns></returns>

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult CustomerInfo()
        {
            //   var status = new SelectList(
            //new[]
            //    {
            //       new { ID = "1", Name = "New" },
            //       new { ID = "2",Name = "Recurrent" }

            //    },
            //    "ID",
            //    "Name"
            //);
            //   ViewBag.paytype = status;

            //   var paymenttype = new SelectList(
            //new[]
            //    {
            //       new { ID = "1", Name = "Cash" },
            //       new { ID = "2",Name = "Cheque" }

            //    },
            //    "ID",
            //    "Name"
            //);
            //   ViewBag.paymentmethod = paymenttype;
            return View();
        }

        public IActionResult MyReport()
        {   //Passing Parameter
            List<DynamicData> shiftTypes = _dataRepository.GetItemsByType("Shift");
            //Load Item in List
            SelectList shiftList = new SelectList(shiftTypes, "ShiftTimingID", "ShiftCode");
            ViewBag.shiftList = shiftList;
            ViewBag.WeekDays = _db2.WeekDays.ToList();
            ViewBag.employees = _db2.Employees.ToList();
            //selected value
            List<EmployeeShift> savedEmployeeShifts = _db2.EmployeeShifts.ToList();
            ViewBag.SavedEmployeeShifts = savedEmployeeShifts;
            //Select Shift Info
            List<ShiftAllInformation> shiftAllInfo = _dataRepository.GetAllShiftInformation("All");
            ViewBag.TableData = shiftAllInfo;
            //Shift Count
            ViewBag.ShiftDataPivot = _dataRepository.GetAllShiftCount();
            return View();
        }

        [HttpPost]
        public IActionResult UpdateSchedule(ScheduleData scheduleData)
        {
            string alertMsg = "";
            var existingEmployeeShift = _db2.EmployeeShifts.FirstOrDefault(x => x.EmployeeId == scheduleData.EmployeeId && x.ShiftDate == scheduleData.Date);

            if (existingEmployeeShift != null)
            {
                existingEmployeeShift.ShiftTimingId = scheduleData.ShiftCode;
                _db2.SaveChanges();
                TempData["alert"] = "Shift updated successfully.";
                //return RedirectToAction("Report");
                return Json(new { success = true });

            }
            else
            {
                var employeeShift = new EmployeeShift()
                {
                    EmployeeId = scheduleData.EmployeeId,
                    ShiftTimingId = scheduleData.ShiftCode,
                    ShiftDate = scheduleData.Date
                };

                _db2.EmployeeShifts.Add(employeeShift);
                _db2.SaveChanges();
                TempData["alert"] = "Data Saved Successfully";
                //return RedirectToAction("Report");
                return Json(new { success = true });
            }



        }


        #endregion
    }
}
