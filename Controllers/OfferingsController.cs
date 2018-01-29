using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Create the add the controller for the AboutPages
namespace Fisher.Bookstore.Controllers
{
    public class OfferingsController: Controller
    {
     // Create a product route
     [Route("Products")]
      [Route("Products/Index")]
    // This method add the controller for the Product
        public  IActionResult Products()
        {
            return Content("This is the Products page");
        }
     // Create a product route
     [Route("Services")]
      [Route("Services/Index")]
    // This method add the controller for the new services page

        public  IActionResult Services()
        {
            return Content("This is the Services page");
        }

    }


}