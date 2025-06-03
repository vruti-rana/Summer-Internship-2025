using Microsoft.AspNetCore.Mvc;
using userportal.Models;
using userportal.Business;


namespace userportal.Controllers
{
    public class Employeecontroller
    {
        private Employeebusiness bll = new Employeebusiness();

        public IActionResult Index()
        {
            return View(bll.GetAllEmployees());
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            bll.AddEmployee(emp);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(bll.GetEmployeeById(id));
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            bll.UpdateEmployee(emp);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(bll.GetEmployeeById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            bll.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}
