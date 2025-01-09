using EMS.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.UOW
{
    public interface IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
        Task<int> SaveDbChangesAsync();
    }
}
