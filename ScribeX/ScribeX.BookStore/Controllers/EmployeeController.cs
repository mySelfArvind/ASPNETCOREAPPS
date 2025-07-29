using Microsoft.AspNetCore.Mvc;
using ScribeX.BookStore.Models;
using ScribeX.BookStore.Repositories;

namespace ScribeX.BookStore.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository _employeeRepository;
        public EmployeeController()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public List<Employee> AllEmployees()
        {
            return _employeeRepository.AllEmployee();
        }

        public Employee? EmployeeId(int id)
        {
            return _employeeRepository.EmployeeById(id);
        }

        public List<Employee>? EmployeeByNameAndDepartment(string name, string department)
        {
            return _employeeRepository.EmployeeByNameOrDepartment(name, department);
        }
    }
}
