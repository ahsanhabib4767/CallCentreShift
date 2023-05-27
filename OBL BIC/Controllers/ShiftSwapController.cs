using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using OBL.BIC.Data;
using OBL.BIC.Model;
using OBL.BIC.SignalR;
using OBL.CSRM.IRepository;
using OBL.CSRM.Model;

namespace OBL.BIC.Controllers
{
    public class ShiftSwapController : Controller
    {
        private ApplicationDbContext _db;
        private TestContext _db2;
        private IConfiguration _configuration;
        private readonly IRepositoryDependency _dataRepository;
        private readonly IHubContext<NotificationHub> _hubContext;
        public ShiftSwapController(ApplicationDbContext db, TestContext db2, IConfiguration iconfig, IRepositoryDependency dataRepository, IHubContext<NotificationHub> hubContext) {
            _db = db;
            _db2 = db2;
            _configuration = iconfig;
            _dataRepository = dataRepository;
            _hubContext = hubContext;
        }
        public IActionResult Index()
        {
            //Swap Info by ID
            List<ShiftAllInformation> shiftAllInfo = _dataRepository.GetAllShiftInformationByID("Individual",Convert.ToInt32(User.Identity.Name));
            ViewBag.TableData = shiftAllInfo;
            //
            List<ShiftTimingDropDown> shiftTypes = _dataRepository.GetAllShiftDropdownInformationByDate(DateTime.Now);
            SelectList shiftList = new SelectList(shiftTypes, "EmployeeID", "DropDownInfo");
            ViewBag.shiftList = shiftList;

            return View();
        }
        [HttpPost]
        public IActionResult LoadDataIntoDropDown(DateTime dateInput)
        {
            List<ShiftTimingDropDown> shiftTypes = _dataRepository.GetAllShiftDropdownInformationByDate(dateInput);
            SelectList shiftList = new SelectList(shiftTypes, "EmployeeID", "DropDownInfo");
            ViewBag.shiftList = shiftList;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Swappp(IFormCollection  forms,int EmployeeID)
        {
            DateTime date = Convert.ToDateTime(forms["dateInputswap"]);
            //EmployeeShift ep = new EmployeeShift();
            string msg = _dataRepository.InsertDataIntoDB(18,EmployeeID, date);
            TempData["alert"] = msg;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Swap(IFormCollection forms, int EmployeeID, [FromServices] IHubContext<NotificationHub> hubContext)
        {
            DateTime date = Convert.ToDateTime(forms["dateInputswap"]);
            string msg = _dataRepository.InsertDataIntoDB(18, EmployeeID, date);

            // Retrieve the user ID of the specific user you want to send the notification to
            string userId = "19"; // Replace with the actual user ID

            // Send the notification to the specific user
            await hubContext.Clients.User(userId).SendAsync("ReceiveNotification", msg);

            TempData["alert"] = msg;
            return RedirectToAction("Index");
        }


    }
}
