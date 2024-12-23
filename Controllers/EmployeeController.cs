using DotnetCore.MediatR_testing.Features.Employees.Command;
using DotnetCore.MediatR_testing.Features.Employees.Query;
using DotnetCore.MediatR_testing.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.MediatR_testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public EmployeeController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet("EmployeeList")]
        public async Task<IActionResult> EmployeeList()
        {
            var employeeList = await _mediatr.Send(new GetEmployeeListQuery());
            return Ok(new
            {
                Data = employeeList
            });
        }

        [HttpGet("EmployeeById/{id}")]
        public async Task<IActionResult> EmployeeById(int id)
        {
            var employee = await _mediatr.Send(new GetEmployeeByIdQuery() { Id = id });
            return Ok(new
            {
                Data = employee
            });
        }

        [HttpPost]
        [Route("AddEmployee")]
        public async Task<Employee> AddEmployee([FromBody] Employee model)
        {
            var employeeRes = await _mediatr.Send(new CreateEmployeeCommand(model.Name, model.Address, model.MobileNumber));
            _mediatr.
            return employeeRes;
        }

        [HttpPut]
        [Route("UpdateEmployee")]
        public async Task<int> UpdateEmployee([FromBody] Employee model)
        {
            var employee = await _mediatr.Send(new UpdateEmployeeCommand(model.Id, model.Name, model.Address, model.MobileNumber));
            return employee;
        }

        [HttpDelete("DeleteEmployee/{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _mediatr.Send(new DeleteEmployeeCommand() { Id = id });
        }
    }
}
