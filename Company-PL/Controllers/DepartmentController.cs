using Company_BLL.Interfaces;
using Company_BLL.Repositories;
using Company_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company_PL.Controllers
{
    public class DepartmentController:Controller
    {
       private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            return View(_departmentRepository.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(T department)
        {
            if (ModelState.IsValid)
            {
                if (_departmentRepository.Add(department)>0)
                {
                    return RedirectToAction("Index");
                }  
            }
                return View(department);
        }

        public IActionResult Details(int id)
        {
            return View(_departmentRepository.GetById(id));
        }
        public IActionResult Update(int id)
        {
            return View(_departmentRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Update(T department)
        {
            if (ModelState.IsValid)
            {
                if (_departmentRepository.Update(department) > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(department);
        }

        public IActionResult Delete(int id)
        {
            return View(_departmentRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Delete(T department)
        {
            if (ModelState.IsValid)
            {
                if (_departmentRepository.Delete(department) > 0)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(department);
        }
    }
}
