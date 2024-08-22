using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IEmployeeRepository:IGenaricRepository<Employee>
    {
        IQueryable<Employee> GetEmployeeByDepartmentName(string departmentName);
        IQueryable<Employee> SearchEmployeesByName(string name);
    }
}
