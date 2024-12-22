using DotnetCore.MediatR_testing.Data.Query;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Data.Handlers
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(request.Id);
        }
    }
}
