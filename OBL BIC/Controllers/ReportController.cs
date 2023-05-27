using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OBL.BIC.Data;
using OBL.BIC.Models;


namespace OBL.BIC.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private ApplicationDbContext _db;
        private PayONE_LBFContext _db2;
        public ReportController(ApplicationDbContext db, PayONE_LBFContext db2)
        {
            _db = db;
            _db2 = db2;
        }
        #region ***Author***
        /// <summary>
        /// By : Ahsan_2022
        /// </summary>
        /// <returns></returns>
        #endregion
        public IActionResult Index()
        {
           
                string branchcode = HttpContext.Session.GetString("LoggedBranchCode") ?? "";
                var req = _db2.CfgBranches.Select(x => new { Text = x.Code + '-' + x.Name, Value = x.Code }).OrderBy(e => e.Text).ToList();
                ViewBag.BranchID = new SelectList(req, "Value", "Text");
                var data = _db2.AccEwuTransactionLogs.Where(x => x.BranchCode == branchcode && x.CreatedOn >= DateTime.Now.AddDays(-2)).ToList();
                ViewBag.TableData = data;
                return View();
         
        }
        public IActionResult ViewInfo()
        {
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult ViewInfo(IFormCollection form)
        {
            string startdate = form["startDate"];
            string enddate = form["endDate"];
            var branchcode = form["BranchID"].ToString();
            //All
            if (!string.IsNullOrEmpty(startdate) && !string.IsNullOrEmpty(enddate)&& !string.IsNullOrEmpty(branchcode))
            {
                var data = _db2.AccEwuTransactionLogs.Where(x => x.TranDate.Date >= Convert.ToDateTime(startdate).Date
                        && x.TranDate.Date <= Convert.ToDateTime(enddate).Date &&  x.BranchCode == branchcode).ToList();
                ViewBag.TableData = data;
            }
            //ONLY Date
            else if (!string.IsNullOrEmpty(startdate) && !string.IsNullOrEmpty(enddate) && string.IsNullOrEmpty(branchcode))
            {
                var data = _db2.AccEwuTransactionLogs.Where(x => x.TranDate.Date >= Convert.ToDateTime(startdate).Date
                        && x.TranDate.Date <= Convert.ToDateTime(enddate).Date).ToList();
                ViewBag.TableData = data;
            }
            //Only Branch 
            else if (!string.IsNullOrEmpty(branchcode))
            {
                var data = _db2.AccEwuTransactionLogs.Where(x => x.BranchCode == branchcode).ToList();
                ViewBag.TableData = data;

            }
            //Only Submit Button
            else
            {
                string br = HttpContext.Session.GetString("LoggedBranchCode") ?? "";
                var data = _db2.AccEwuTransactionLogs.Where(x => x.BranchCode == br).ToList();
                ViewBag.TableData = data;
            }

            ViewBag.BranchID2 = branchcode;
            var req = _db2.CfgBranches.Select(x => new { Text = x.Code + '-' + x.Name, Value = x.Code }).OrderBy(e => e.Text).ToList();
            //var data = _db2.AccEwuTransactionLogs.Where(x => x.BranchCode == branchcode || x.TranDate.Date >= startdate.Date && x.TranDate.Date <= endDate.Date).ToList();
            //ViewBag.TableData = data;
            ViewBag.BranchID = new SelectList(req, "Value", "Text");
            return View("Index");
        }

        
    }
}
