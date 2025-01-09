using EMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Repositories
{
    public interface IEmployeeRepository
    {
        Task <List<Employee>> GetAllEmployees(); // task for all Employee and call in Class
        Task SaveEmployee(Employee employee); // task for add Employee and call in Class
        Task<List<Employee>> FindEmployeeByNameAsync(string name); // task for find Employee by ID and call in class
    }
}
