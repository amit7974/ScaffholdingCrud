using Microsoft.AspNetCore.Mvc;
using ScallfoldingCrud.Models;

namespace ScallfoldingCrud.Controllers
{
    public class EmployeeController : Controller
    {

        List<Employee> employees = new List<Employee>() {
                // create some sample employee data objects and add them to the list

                new Employee(){ empid = 1, name = "Amit Raj", gender = "M", dob = new DateTime(1990, 1, 1), emailid = "aayanraj934@gmail.com" },

                new Employee(){ empid = 2, name = "Lione", gender = "F", dob = new DateTime(1990, 1, 1), emailid = "lione.com" },
                new Employee(){ empid = 3, name = "John Doe", gender = "M", dob = new DateTime(1990, 1, 1), emailid = "john.doe@example.com" },


            };
        public IActionResult Index()
        {
            //whenyou have a list of employees, you can create a sample list of employees to display in the view. Here's an example of how you can do that:

           
            return View(employees);

        }
            public IActionResult Create()
        {
            return View();

        }

        public IActionResult Edit(int id)
        {
            Employee emp = employees.FirstOrDefault(x => x.empid == id);
            return View(emp);

        }

        public IActionResult Details( int id)
        {
            Employee emp = employees.FirstOrDefault(x => x.empid == id);
            return View(emp);

        }

        public IActionResult Delete(int id)
        {
            Employee emp = employees.FirstOrDefault(x => x.empid == id);
            return View(emp);

        }


    }

        }



 