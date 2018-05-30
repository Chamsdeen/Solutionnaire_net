using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atelier_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atelier_3.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeesData data = new EmployeesData();

        public IActionResult Index()
        {
            string output = "<table border=1>";
            foreach(Employee e in data.employees)
            {
                output += "<tr>";
                output += "<td>" + e.Id + "</td>";
                output += "<td>" + e.FirstName + "</td>";
                output += "<td>" + e.LastName + "</td>";
                output += "</tr>";
            }
            output += "</table>";

            return Content(output, "text/html");
        }
    }
}