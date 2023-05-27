using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OBL.BIC.Model;
using OBL.BIC.ServiceDependencies;

namespace OBL.BIC.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private TestContext _db2;
        private readonly IConfiguration _configuration;
        private readonly Authentication userAuthDetails;
        public UserController(IConfiguration configuration, TestContext db)
        {
            _db2 = db;
            _configuration = configuration;
            userAuthDetails = new Authentication(_configuration.GetValue<string>("ApplicationSettings:APIWebAddress"));
        }
    #region ***Author***
    /// <summary>
    /// By : Ahsan_2022
    /// </summary>
    /// <returns></returns>
    #endregion

    [HttpGet]
        public IActionResult Index()
        {
            string emp = User.Identity.Name;
            //DateTime d1 = Convert.ToDateTime(bDate);
            var data = _db2.AccBicUsers.ToList();
            ViewBag.TableData = data;
            return View(data);
        }

        public IActionResult LoadInfo()
        {
            return View(nameof(Index));
        }

        //if status value is inative then remove the user from the list; otherwise update

        [HttpPost]
        public async Task<IActionResult> AddUser(string empIdTxtBx,string empName, string statusDDn,string empBrTxtBx)
        {
            string alertMsg = "";
            //if (string.IsNullOrEmpty(roleDDn) || string.IsNullOrEmpty(statusDDn))
            //{
            //    alertMsg = "Check Detailed Information";
            //}
            if (!string.IsNullOrEmpty(statusDDn))
            {
                var userExistinUserList = _db2.AccBicUsers.Where(x => x.Employeeid == empIdTxtBx).FirstOrDefault();

                //if (statusDDn.Equals("1"))
                //{

                if (userExistinUserList != null)
                {
                    if (userExistinUserList.Employeeid == empIdTxtBx && userExistinUserList.Usertype == statusDDn && userExistinUserList.IsActive == true)
                    {
                        alertMsg = "User Already Exist";
                    }
                    else
                    {
                        userExistinUserList.Employeeid = empIdTxtBx;
                        userExistinUserList.Employeename = empName;
                        userExistinUserList.Empbranchcode = empBrTxtBx;
                        userExistinUserList.Usertype = statusDDn;
                        userExistinUserList.IsActive = true;
                        userExistinUserList.ModifiedOn = DateTime.Now;
                        userExistinUserList.ModifiedBy = User.Identity.Name;
                        alertMsg = "User Information Updated";
                        _db2.SaveChanges();

                    }
                }
                else
                {
                    alertMsg = "User Information Added";
                    AccBicUser userListModel = new AccBicUser();
                    userListModel.Employeeid = empIdTxtBx;
                    userListModel.Empbranchcode = empBrTxtBx;
                    userListModel.Usertype = statusDDn;
                    userListModel.Employeename = empName;
                    userListModel.CreatedOn = DateTime.Now;
                    userListModel.CreatedBy = User.Identity.Name;
                    userListModel.IsActive = true;
                    await _db2.AccBicUsers.AddAsync(userListModel);
                    await _db2.SaveChangesAsync();
                }
                TempData["alert"] = alertMsg;
                return RedirectToAction(nameof(Index));
            }

            return Ok();

        }

    

    }
}
