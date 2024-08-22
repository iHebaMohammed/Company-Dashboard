using Demo.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Contexts
{
    public class MVCDbContextRoute : IdentityDbContext<ApplicationUser>
    {
        public MVCDbContextRoute(DbContextOptions<MVCDbContextRoute> options): base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server =.; Database = MVCDbContextRoute; Trusted_Connection =True; MultipleActiveResultSets = true;");
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        //public DbSet<IdentityUser> Users { get; set; }
        //public DbSet<ApplicationUser> User { get; set; }
    }
}
