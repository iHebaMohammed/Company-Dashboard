using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entities;
using Demo.PL.Helpers;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork
            , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(string SearchValue)
        {
            var employees = Enumerable.Empty<Employee>(); // Empty Sequence 
            if (string.IsNullOrEmpty(SearchValue))
            {
                employees = await _unitOfWork.EmployeeRepository.GetAll();
            }
            else
            {
                employees = _unitOfWork.EmployeeRepository.SearchEmployeesByName(SearchValue);
            }
            var mappedEmployees = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
            return View(mappedEmployees);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await _unitOfWork.DepartmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid) // Server side validation
            {
                /// Manual Mapping
                ///var mappedEmployee = new Employee()
                ///{
                ///    Name = employeeVM.Name,
                ///    Address = employeeVM.Address,
                ///    Age = employeeVM.Age,
                ///    DepartmentId = employeeVM.DepartmentId,
                ///   Email = employeeVM.Email,
                ///    HireDate = employeeVM.HireDate,
                ///    IsActive = employeeVM.IsActive,
                ///   PhoneNumber = employeeVM.PhoneNumber,
                ///    Salary = employeeVM.Salary
                ///};

                employeeVM.ImageName = await DocumentSettings.UploadFile(employeeVM.Image, "images");

                /// Auto Mapper
                var mappedEmployee = _mapper.Map<EmployeeViewModel , Employee>(employeeVM);
                await _unitOfWork.EmployeeRepository.Add(mappedEmployee);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(employeeVM);
            }

        }
        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (id == null)
                return NotFound();
            var employee = await _unitOfWork.EmployeeRepository.GetById(id.Value);
            if (employee == null)
                return NotFound();
            
            var mappedEmployee = _mapper.Map<Employee, EmployeeViewModel>(employee);
            return View(ViewName, mappedEmployee);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Departments = await _unitOfWork.DepartmentRepository.GetAll();
            return await Details(id, "Edit");
            ///if (id == null)
            ///    return BadRequest();
            ///var Employee = _EmployeeRepository.GetById(id.Value);
            ///if (Employee == null)
            ///    return BadRequest();
            ///return View(Employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            if (ModelState.IsValid)
            {
                try
                {

                    //employeeVM.ImageName = await DocumentSettings.UploadFile(employeeVM.Image, "images");
                    var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    var result = await _unitOfWork.EmployeeRepository.Update(mappedEmployee);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // 1. Log exception in database
                    // 2. Friendly message
                    ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
                }
            }
            return View(employeeVM);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteAsync(EmployeeViewModel employeeVM, int id)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            try
            {
                var mappedEmployee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                var result = await _unitOfWork.EmployeeRepository.Delete(mappedEmployee);
                if(result > 0)
                    DocumentSettings.DeleteFile(employeeVM.ImageName, "images");

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // 1. Log exception in database
                // 2. Friendly message
                ModelState.AddModelError(string.Empty, ex.Message); // 3. Not friendly massage
            }
            return View(employeeVM);
        }
    }
}
