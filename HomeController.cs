using PracticeMVC14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeMVC14.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var CountryList = new List<string> { "India", "China", "America", "Japan" };
            ViewBag.CountryList = CountryList;
            return View();
        }
        public ActionResult Details()
        {
            TempData.Keep();
            return View();
        }



        [HttpPost]
        public ActionResult Index(Employee emp)
        {

            var CountryList = new List<string> { "India", "China", "America", "Japan" };
            ViewBag.CountryList = CountryList;

            emp.EmpOrganisationName = "Aakash Investments";


            if (ModelState.IsValid == true) 
            {
                ViewData["SuccessMessage"] = "<script>Swal.fire(\r\n  'Data has been submitted succesfully!',\r\n  'Thank You!',\r\n  'success'\r\n)</script>";
                ModelState.Clear();
                RedirectToAction("Details");
            }



            TempData["empId"] = emp.EmpId;
            TempData["empName"] = emp.EmpName;
            TempData["empEmail"] = emp.EmpEmail;
            TempData["empMobile"] = emp.EmpMobile;
            TempData["empOrgainsationName"] = emp.EmpOrganisationName;
            TempData["empGender"] = emp.EmpGender;
            TempData["empAge"] = emp.EmpAge;
            TempData["empPassword"] = emp.EmpPassword;
            TempData["empJoiningDate"] = emp.EmpJoiningDate;
            TempData["empCountry"] = emp.EmpCountry;
            TempData["empAddress"] = emp.EmpAddress;

            TempData.Keep();

            return View();
        }
    }
}