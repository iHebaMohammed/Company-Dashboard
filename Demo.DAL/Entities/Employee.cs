using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        [MinLength(2)]
        [DataType("varchar")]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }

        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [ForeignKey("Department")]
        public int? DepartmentId { get; set; } // ForeignKey Allow Null
        // Navigational Proprty -- One 
        public Department Department { get; set; }
        public string ImageName { get; set; }
    }
}
