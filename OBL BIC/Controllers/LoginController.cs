using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using OBL.BIC.Data;
//using OBL.BIC.Temp;
using OBL.BIC.ServiceDependencies;
using System.Collections;
using OBL.BIC.Models;
using System.Configuration;
using OBL.BIC.Model;

namespace OBL.BIC.Controllers
{
  

    public class LoginController : Controller
    {
        #region ***Author***
        /// <summary>
        /// By : Ahsan_2022
        /// </summary>
        /// <returns></returns>
        #endregion

        #region ***** Variable and Instance declaration ****
        private ApplicationDbContext _db;
        private TestContext _db2;
        private readonly Authentication userAuthDetails;
        private readonly IConfiguration _configuration;
        #endregion

        #region ***** Constructor ****
        public LoginController(ApplicationDbContext db, TestContext db2, IConfiguration configuration)
        {
            ViewData["Title"] = "PayONE ";
            _db = db;
            _db2 = db2;
            _configuration = configuration;
            userAuthDetails = new Authentication(_configuration.GetValue<string>("ApplicationSettings:APIWebAddress"));

        }
        #endregion

        [HttpGet("login")]
        public IActionResult Index(string returnUrl)
        {

            ViewData["ReturnUrl"] = returnUrl;
            ViewData["Title"] = "Login";
            if (!string.IsNullOrEmpty(User.Identity.Name))
            {
                return Redirect(returnUrl);//View("Index", "Home");
            }
            return View();
        }

        //[HttpPost("login")]
        //public IActionResult Index(string FirstName, string LastName)
        //{
        //    OBLSoft.Infrastructure.APIService.Authentication userAuthDetails = new OBLSoft.Infrastructure.APIService.Authentication();
        //    if (userAuthDetails.CheckUserAuthentication(FirstName, LastName))
        //    {
        //       // FormsAuthentication.SetAuthCookie(FirstName, false);
        //        //FormsAuthentication.SetAuthCookie();
        //        return RedirectToAction("Index", "Home");
        //    }


        //    return NotFound();

        //}

        [HttpPost("login")]
        public async Task<IActionResult> Validate(int EmpID, string Pwd, string returnUrl)
        {
            returnUrl = "/";
            try
            {
                ViewData["ReturnUrl"] = returnUrl;
                //Authentication userAuthDetails = new Authentication();
                var userid = _db2.Employees.Where(x => x.EmployeeId == EmpID && x.IsActive == true).FirstOrDefault();
                if (userid != null)
                {
                    if (true)//userAuthDetails.CheckUserAuthentication(EmpID, Pwd))
                    {
                        HttpContext.Session.SetString("USERTYPE", userid.Usertype);
                        HttpContext.Session.SetString("LoggedUserName", userid.EmployeeName);
                        //var empClaimName = _db.
                        var claims = new List<Claim>();
                        claims.Add(new Claim("username", EmpID.ToString()));
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, EmpID.ToString()));
                        claims.Add(new Claim(ClaimTypes.Name, EmpID.ToString()));
                        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        //var x = User.Identity.Name;
                        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                        await HttpContext.SignInAsync(claimsPrincipal);
                        //TempData["alert"] = "LOGIN SUCCESSFUL !";
                        return Redirect(returnUrl);
                }
                else
                {
                    ViewBag.ErrorMessage = "Username not found in OBL Connect/Incorrect Password!";
                }
            }
                else
                {  
                    ViewBag.ErrorMessage = "Username is not Registered";
                }
                //return Redirect("/");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return View("Index");
        }

        [Authorize]
       public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
