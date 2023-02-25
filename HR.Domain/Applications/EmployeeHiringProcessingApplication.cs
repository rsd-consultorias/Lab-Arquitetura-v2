using System;
using Core.Types;
using HR.Domain.Builders;
using HR.Domain.Interfaces;
using HR.Domain.Models;
using HR.Domain.Types;

namespace HR.Domain.Applications
{
    public class EmployeeHiringProcessingApplication
    {
        private readonly IEmployeeRepository _repository;
        private readonly IPayrollService _payrollService;

        public EmployeeHiringProcessingApplication(IEmployeeRepository repository, IPayrollService payrollService)
        {
            _repository = repository;
            _payrollService = payrollService;
        }

        public ApplicationResponse Start(string name, DateTime birthDate, string nationalId)
        {
            var employee = EmployeeBuilder.BuildHiringEmployee(name, birthDate, nationalId);
            employee.Validate();

            if (employee.IsValid)
            {
                if (_repository.Create(employee)) { return new ApplicationResponse(false, _repository.LastError); };
                if (_payrollService.StartProfileCreation(employee)) { return new ApplicationResponse(false, _payrollService.LastError); }
            }
            else
            {
                return new ApplicationResponse(false, string.Concat(employee.Errors));
            }

            return new ApplicationResponse(true);
        }

        public ApplicationResponse ApplyEligibleSalary(Money salary, Employee employee)
        {
            employee = EmployeeBuilder.ApplyAllValidations(employee);
            employee.Validate();

            if (employee.IsValid)
            {
                if (!_repository.Update(employee))
                {
                    return new ApplicationResponse(false, _repository.LastError);
                }
            }
            else
            {
                return new ApplicationResponse(false, string.Concat(employee.Errors));
            }

            return new ApplicationResponse(true);
        }
    }
}

