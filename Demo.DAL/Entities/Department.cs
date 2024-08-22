using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{

    // Domain Model 
    //Poco Class
    public class Department
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        
        public DateTime DateOfCreation { get; set; }

        //Navigatioanl Property -- Many
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
