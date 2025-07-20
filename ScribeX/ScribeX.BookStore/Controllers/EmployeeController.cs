using Microsoft.AspNetCore.Mvc;

namespace ScribeX.BookStore.Controllers
{
    public class EmployeeController : Controller
    {
        public string AllEmployees()
        {
            return "All Employee";
        }

        public string EmployeeId(int id)
        {
            return $"Employee with Id: {id}";
        }

        public string EmployeeByNameAndDepartment(string name, string department)
        {
            return $"Employee Name : {name} & Department : {department}";
        }
    }
}
