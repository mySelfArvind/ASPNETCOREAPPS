using ScribeX.BookStore.Models;

namespace ScribeX.BookStore.Repositories
{
    public class EmployeeRepository
    {
        public List<Employee> AllEmployee()
        {
            return DataSource();
        }

        public Employee? EmployeeById(long id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Employee> EmployeeByNameOrDepartment(string Name, string Department)
        {
            List<Employee> employees =  DataSource().Where(x => x.Name.Contains(Name) || x.Department.Contains(Department)).ToList();
            return employees;
        }

        public List<Employee> DataSource()
        {
            return new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Arvind", DOB = "1 Jan 2001", DOJ = System.DateTime.Now.AddYears(-3), Department = "IT" },
                new Employee() { Id = 2, Name = "Priya", DOB = "12 Mar 1999", DOJ = System.DateTime.Now.AddYears(-4), Department = "HR" },
                new Employee() { Id = 3, Name = "Rohan", DOB = "25 Jul 2000", DOJ = System.DateTime.Now.AddYears(-2), Department = "Finance" },
                new Employee() { Id = 4, Name = "Sneha", DOB = "5 Oct 1998", DOJ = System.DateTime.Now.AddYears(-5), Department = "Marketing" },
                new Employee() { Id = 5, Name = "Vikram", DOB = "30 Dec 1997", DOJ = System.DateTime.Now.AddYears(-6), Department = "Operations" },
                new Employee() { Id = 6, Name = "Meena", DOB = "15 Jun 2001", DOJ = System.DateTime.Now.AddYears(-3), Department = "Operations" },
                new Employee() { Id = 7, Name = "Arvind", DOB = "1 Jan 2001", DOJ = System.DateTime.Now.AddYears(-3), Department = "CS" },
            };
        }
    }
}
