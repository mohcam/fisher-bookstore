using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// Create the add the controller for the AboutPages
namespace Fisher.Bookstore.Controllers
{
    public class Authors: Controller
    {
    // This method add the controller for the booksIndex
        public  IActionResult Index()
        {
            return Content("This is the AuthorController Index");
        }
    // This method add the controller for the new Book

        public  IActionResult Featured()
        {
            return Content("This is the AuthorController Featured");
        }

    }


}