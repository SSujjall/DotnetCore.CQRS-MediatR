using DotnetCore.MediatR_testing.Data.Query;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Data.Handlers
{
    public class GetEmployeeListHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeListHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeListAsync();
        }
    }
}
