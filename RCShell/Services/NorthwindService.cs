using Microsoft.EntityFrameworkCore;
using Northwind.DataAccess;
using Northwind.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCShell.Services
{
    public class NorthwindService : INorthwindService
    {
        private readonly NorthwindDBContext dbContext;
        public NorthwindService(NorthwindDBContext context)
        {
            dbContext = context;
        }

        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await dbContext.Employees.Select(e => new Employee
            {
                EmployeeId = e.EmployeeId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                HomePhone = e.HomePhone,
                //Manager = e.Manager,
                //Employees = e.Employees,
                Notes = e.Notes,
                //ReportsTo = e.ReportsTo,
                Title = e.Title
            }).ToListAsync();
        }


    }
}
