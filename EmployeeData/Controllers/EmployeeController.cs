using EmployeeData.DAL;
using EmployeeData.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext _context;

        public EmployeeController(EmployeeDBContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            List<EmployeeViewModel> employeesList = new List<EmployeeViewModel>();
            if (employees !=null)
            {
                foreach(var employee in employees)
                {
                    var EmployeeViewModel = new EmployeeViewModel()
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        DateOfBirth = employee.DateOfBirth,
                        Email = employee.Email,
                        Salary = employee.Salary,

                    };
                    employeesList.Add(EmployeeViewModel);
                }
                return View(employeesList);
            }
            return View(employeesList);
        }
    }
}
