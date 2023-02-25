using System;
using Core.Models;
using HR.Domain.Models;

namespace HR.Domain.Builders
{
    public sealed class EmployeeBuilder
    {
        // Validations
        private static string? ValidateNationalId(BaseModel model)
        {
            Employee employee = (Employee)model;

            string error = string.Empty;

            if (!string.IsNullOrEmpty(employee.NationalId))
            {
                error += "National ID is required. ";
            }
            if (employee.NationalId != null && employee.NationalId!.Length != 11)
            {
                error += "National ID length should have 11 digits. ";
            }

            return error;
        }

        private static string? ValidateMinimalAge(BaseModel model)
        {
            Employee employee = (Employee)model;

            string error = string.Empty;

            if (employee.BirthDate > employee.BirthDate.AddYears(-18))
            {
                error += "Employee's age should be greater than 18 years. ";
            }

            return error;
        }

        private static string? ValidateCostCenter(BaseModel model)
        {
            Employee employee = (Employee)model;

            return string.IsNullOrEmpty(employee.CostCenter) ? "Employee should be allocated in cost center. " : string.Empty;
        }

        // Builders
        public static Employee BuildHiringEmployee(string name, DateTime birthDate, string nationalId)
        {
            Employee employee = new Employee
            {
                Name = name,
                BirthDate = birthDate,
                NationalId = nationalId
            };

            employee.AddValidation(ValidateNationalId);
            employee.AddValidation(ValidateMinimalAge);

            return employee;
        }

        public static Employee ApplyAllValidations(Employee employee)
        {
            employee.AddValidation(ValidateNationalId);
            employee.AddValidation(ValidateMinimalAge);
            employee.AddValidation(ValidateCostCenter);

            return employee;
        }
    }
}

