using ASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public static List<Employee> empList = new List<Employee>() {
            new Employee(01,"Tony","Br","Male",5000),
            new Employee(02,"Chris","James","Male",1000),
            new Employee(03,"Iris","Li","Female",1200)
        };
        public ActionResult Index()
        {
            return View(empList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                empList.Add(emp);
                return RedirectToAction("Index", "Employee");
            }
            return View(emp);
        }
        public ActionResult Details(int Id)
        {
            Employee employee = empList.Where(x => x.ID == Id).Single();
            return View(employee);
        }
        public ActionResult Edit(int Id)
        {
            Employee employee = empList.Where(x => x.ID == Id).Single();
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {
            if (ModelState.IsValid)
            {
                Employee employee = empList.Where(x => x.ID == emp.ID).Single();
                empList.Remove(employee);
                empList.Add(emp);
                return RedirectToAction("Index", "Employee");
            }
            return View(emp);
        }
        public ActionResult Delete(int? Id)
        {
            Employee employee = empList.Where(x => x.ID == Id).Single();
            return View(employee);
        }
        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Employee employee = empList.Where(x => x.ID == Id).Single();
            empList.Remove(employee);
            return RedirectToAction("Index", "Employee");
        }
    }
}