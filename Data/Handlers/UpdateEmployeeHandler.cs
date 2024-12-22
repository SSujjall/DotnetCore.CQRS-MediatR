﻿using DotnetCore.MediatR_testing.Data.Command;
using DotnetCore.MediatR_testing.Models;
using DotnetCore.MediatR_testing.Services.Interface;
using MediatR;

namespace DotnetCore.MediatR_testing.Data.Handlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;

            employee.Name = request.Name;
            employee.Address = request.Address;
            employee.MobileNumber = request.MobileNumber;
            return await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}