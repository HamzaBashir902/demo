using EMS.Domain.Entities;
using EMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext) 
        {
            _employeeDbContext = employeeDbContext;
        }
        public async Task<List<Employee>> GetAllEmployees() // Implemention of Interfaces Tasks
        {
            var employees = await _employeeDbContext.Employees.ToListAsync();
            return employees;
        }
        public async Task SaveEmployee(Employee employee)  // Implemention of Interfaces Tasks
        {
            await _employeeDbContext.Employees.AddAsync(employee);
        }
        public async Task<List<Employee>> FindEmployeeByNameAsync(string name)
        {
                return (from employee in _employeeDbContext.Employees
                          where employee.name == name
                          select employee).ToList();
        }
    }
}
