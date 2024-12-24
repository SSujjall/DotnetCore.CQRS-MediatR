using DotnetCore.MediatR_testing.Features.Departments.Command;
using DotnetCore.MediatR_testing.Features.Departments.Query;
using DotnetCore.MediatR_testing.Features.Employees.Command;
using DotnetCore.MediatR_testing.Features.Employees.Query;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Models.DTOs.DepartmentDTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetCore.MediatR_testing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IMediator _mediatr) : ControllerBase
    {
        [HttpGet("DepartmentList")]
        public async Task<IActionResult> DepartmentList()
        {
            var result = await _mediatr.Send(new GetDepartmentListQuery());
            return Ok(new
            {
                Data = result
            });
        }

        [HttpGet("DepartmentById/{id}")]
        public async Task<IActionResult> DepartmentById(int id)
        {
            var result = await _mediatr.Send(new GetDepartmentByIdQuery() { Id = id });
            return Ok(new
            {
                Data = result
            });
        }

        [HttpPost("AddDepartment")]
        public async Task<Department> AddDepartment(AddDepartmentDTO model)
        {
            var result = await _mediatr.Send(new CreateDepartmentCommand { Name = model.Name});
            return result;
        }

        [HttpPut("UpdateDepartment")]
        public async Task<int> UpdateDepartment(UpdateDepartmentDTO model)
        {
            var result = await _mediatr.Send(new UpdateDepartmentCommand { Id = model.Id, Name = model.Name });
            return result;
        }

        [HttpDelete("DeleteDepartment/{id}")]
        public async Task<int> DeleteDepartment(int id)
        {
            return await _mediatr.Send(new DeleteDepartmentCommand() { Id = id });
        }
    }
}
