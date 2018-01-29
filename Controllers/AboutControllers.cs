using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Create the add the controller for the AboutPages
namespace Fisher.Bookstore.Controllers
{
    public class AboutController: Controller
    {
    // This method add the controller for the aboutIndex
        public  IActionResult Index()
        {
            return Content("This is the AboutController Index");
        }
    // This method add the controller for the About location

        public  IActionResult History()
        {
            return Content("This is the AboutController History");
        }

        public  IActionResult Location()
        {
            return Content("This is the AboutController Location");
        }
    }


}