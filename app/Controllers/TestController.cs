using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
       
        public IActionResult Error()
        {
            return View();
        }
    }
}
