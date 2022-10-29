using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StudentInfo.Models;
using System.Diagnostics;

namespace StudentInfo.Controllers
{
    public class HomeController : Controller
    {
        private EmployeesDbContext Students { get; set; } //connects to the context mode

        public HomeController(EmployeesDbContext con)
        //information to connect to the database, context model
        {
            Students = con;
        }

        [HttpGet]
        public IActionResult Index() //return get request for the View Movies table
        {
            var table = Students.Employees.ToList();
            return View(table);
        }

    }
}
