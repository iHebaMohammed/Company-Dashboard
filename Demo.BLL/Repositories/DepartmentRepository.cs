﻿using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : GenaricRepository<Department> , IDepartmentRepository
    {
        public DepartmentRepository(MVCDbContextRoute dbContext) : base(dbContext)
        {
        }
    }
}
