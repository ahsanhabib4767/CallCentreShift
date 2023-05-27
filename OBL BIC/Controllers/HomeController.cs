using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OBL.BIC.Data;
//using OBL.BIC.Models;
using OBL.BIC.ServiceDependencies;
using System.Configuration;
//using OBL.BIC.Temp;
using System.Diagnostics;

namespace OBL.BIC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        #region ***** Variable and Instance declaration ****
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _db;
        private readonly Authentication userAuthDetails;
      
        private readonly IConfiguration _configuration;
        #endregion

        #region ***** Constructor ****
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db,IConfiguration configuration)
        {
            _logger = logger;
            _db = db;
            _configuration = configuration;
            userAuthDetails = new Authentication(_configuration.GetValue<string>("ApplicationSettings:APIWebAddress"));
            //_intra_db = intradb;
        }
        #endregion

        public IActionResult Index()
        {
            #region ----- note ------
            //session add for user track
            //user role
            //Authentication userDetail = new Authentication();
            //userDetail.GetUserProfile("016012403095");
            #endregion
            ViewData["Title"] = "Home";
            //Authentication userAuthDetails = new Authentication();
            var curUserDetail = userAuthDetails.GetUserProfileList(User.Identity.Name.Trim());// _intra_db.Oblintraemployeeviews.Where(x => x.Code == User.Identity.Name.Trim()).ToList();
            var loggedUserInfo = userAuthDetails.GetUserProfile(User.Identity.Name.Trim());
            //IList x = z as IList;
            string type = HttpContext.Session.GetString("USERTYPE")??"";
            //HttpContext.Session.SetString("LoggedUserName", loggedUserInfo.Name);
            //HttpContext.Session.SetString("LoggedUserEmpID", loggedUserInfo.Code);
            //HttpContext.Session.SetString("LoggedBranchCode", loggedUserInfo.Branchcode);
            //HttpContext.Session.SetString("LoggedBranchName", loggedUserInfo.Branchname);
            //HttpContext.Session.SetString("CurrentUser", User.Identity.Name);  
            //HttpContext.Session.SetString("Type",type);
            var CurrentUserRole = "";
            //if (curUserDetail.Any())
            //{
            //    string curUserEmail = curUserDetail[0].Oblemail;
            //    //var curUserListData = _db.OBLUmsUserList.Where(x => x.Email == curUserEmail).ToList();
            //    //if (curUserListData.Any())
            //    //{
            //        //CurrentUserRole = curUserListData[0].Role;
            //    //}
            //    //else
            //    //{
            //    //    CurrentUserRole = "UC";
            //    //}
            //}
            //else
            //{

            //}
            //HttpContext.Session.SetString("CurrentUserRole", CurrentUserRole);
            
            return View();
        }


    }
}