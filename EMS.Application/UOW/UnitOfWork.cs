using EMS.Application.Repositories;
using EMS.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private EmployeeDbContext _employeeDbContext;
        public IEmployeeRepository EmployeeRepository { get; }
        public UnitOfWork(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
            EmployeeRepository = new EmployeeRepository(_employeeDbContext);
        }
        public async Task<int> SaveDbChangesAsync()
        {
            return await _employeeDbContext.SaveChangesAsync();
        }


    }
}
