using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        //[AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            // 1. ViewDate -> Dectionary Object "Key , Value"
            ViewData["Message"] = "Hello View Data"; //To Transfare data from action to view 
            // 2. ViewBag -> dynamic program
            ViewBag.Mesg = "Hello View Bag";//To Transfare data from action to view 


            var departments = await _unitOfWork.DepartmentRepository.GetAll();
            var mappedDepartments = _mapper.Map<IEnumerable<Department> , IEnumerable<DepartmentViewModel>>(departments);
            return View(mappedDepartments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentViewModel departmentVM)
        {
            if (ModelState.IsValid) // Server side validation
            {
                var mappedDepartment = _mapper.Map<DepartmentViewModel , Department>(departmentVM);
                await _unitOfWork.DepartmentRepository.Add(mappedDepartment);
                TempData["DeptName"] = departmentVM.Name; //To Transfare data from action to action 
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(departmentVM);
            }

        }
        public async Task<IActionResult> Details(int ? id , string ViewName = "Details")
        {
            if(id == null)
                return NotFound();
            var department = await _unitOfWork.DepartmentRepository.GetById(id.Value);
            if (department == null)
                return NotFound();
            var mappedDepartment = _mapper.Map<Department, DepartmentViewModel>(department);
            return View(ViewName , mappedDepartment);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int ? id)
        {
            return await Details(id , "Edit");
            ///if (id == null)
            ///    return BadRequest();
            ///var department = _departmentRepository.GetById(id.Value);
            ///if (department == null)
            ///    return BadRequest();
            ///return View(department);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute]int id, DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {
                    var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                    var result = await _unitOfWork.DepartmentRepository.Update(mappedDepartment);
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    // 1. Log exception in database
                    // 2. Friendly message
                    ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
                }
            }
            return View(departmentVM);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DepartmentViewModel departmentVM , int id)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            try
            {
                var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                var result = await _unitOfWork.DepartmentRepository.Delete(mappedDepartment);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // 1. Log exception in database
                // 2. Friendly message
                ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
            }
            return View(departmentVM);
        }
    }
}
