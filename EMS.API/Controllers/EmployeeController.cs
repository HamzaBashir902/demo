using Microsoft.AspNetCore.Mvc;
using EMS.Application.UOW;
using EMS.Domain.Entities;
namespace EMS.API.Controllers
    // Ya empty Cintroller sy add howa tha
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IUnitOfWork _UnitOfWork ;    // Interface ko use kia ha
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;   
        }
        [HttpGet("Get Employees")] // end point
        public async Task<IActionResult> GetAllEmployees() // action result
        {
            var emp = await _UnitOfWork.EmployeeRepository.GetAllEmployees();
            return Ok(emp); // API response
        }
 //       [HttpPost("Add Empployee")]
        //public async Task<> SaveEmployee()
        //{
        //    var 
        //}

    }
}
