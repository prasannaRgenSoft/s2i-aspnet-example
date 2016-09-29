using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Show()
        {
            
             //EmployeeModel e = new EmployeeModel { City = "Mumbai", Designation="Lead", EmpLastName="Shukla", EmpName="Shakal", Gender=true, Id=101, Salary=100 };
             //return Json(e);
             return View();
        }
       
        public IActionResult Error()
        {
            return View();
        }
    }
}
