using Demo.DAL.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.PL.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required!")]
        [MaxLength(50, ErrorMessage = "Max Lenngth is 50 Char")]
        [MinLength(2, ErrorMessage = "Min Length is 2")]
        [DataType("varchar")]
        public string Name { get; set; }

        [Range(22, 50, ErrorMessage = "Age must be between 22 and 30")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Address is Required!")]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        [Range(4000, 8000)]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }

        [ForeignKey("Department")]
        [Display(Name = "Department")]
        public int? DepartmentId { get; set; } // ForeignKey Allow Null
        // Navigational Proprty -- One 
        public Department Department { get; set; }
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }
    }
}
