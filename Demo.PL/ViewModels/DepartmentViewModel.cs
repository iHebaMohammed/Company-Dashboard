using Demo.DAL.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Demo.PL.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required")]
        [MaxLength(10)]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Max Length Name is 50 Chars")]
        public string Name { get; set; }

        public DateTime DateOfCreation { get; set; }

        //Navigatioanl Property -- Many
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
