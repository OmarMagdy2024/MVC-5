using Company_BLL.Interfaces;
using Company_BLL.Repositories;
using Company_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company_PL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        //private readonly IDepartmentRepository _departmentRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            //_departmentRepository = departmentRepository;
        }
        public IActionResult Index(string Search)
        {
            if (string.IsNullOrEmpty(Search))
            {
                return View(_employeeRepository.GetAll());

            }

            else
            {
                return View(_employeeRepository.GetbyName(Search));
            }
        }

        public IActionResult Create()
        {
            //ViewBag.Department = _departmentRepository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (_employeeRepository.Add(employee) > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }

        public IActionResult Details(int id)
        {
            return View(_employeeRepository.GetById(id));
        }
        public IActionResult Update(int id)
        {
            return View(_employeeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (_employeeRepository.Update(employee) > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            return View(_employeeRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (_employeeRepository.Delete(employee) > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(employee);
        }
    }
}
