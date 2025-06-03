using userportal.Data;
using userportal.Models;

namespace userportal.Business
{
    public class Employeebusiness
    {
        private Employeedata dal = new Employeedata();

        public List<Employee> GetAllEmployees() => dal.GetAllEmployees();
        public void AddEmployee(Employee emp) => dal.AddEmployee(emp);
        public Employee GetEmployeeById(int id) => dal.GetEmployeeById(id);
        public void UpdateEmployee(Employee emp) => dal.UpdateEmployee(emp);
        public void DeleteEmployee(int id) => dal.DeleteEmployee(id);
    }
}
