using HR.Domain.Interfaces;
using HR.Domain.Models;
using Logging;

namespace HR.API.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IModelLogging<Employee> _modelLogging;
        private readonly IExceptionLogging _exceptionLogging;

        public EmployeeRepository(IModelLogging<Employee> modelLogging, IExceptionLogging exceptionLogging)
        {
            _modelLogging = modelLogging;
            _exceptionLogging = exceptionLogging;
        }

        public string? LastError { get; set; }

        public bool Create(Employee model)
        {
            try
            {
                // Call Entity Framework
                _modelLogging.LogCreated(model);
                return true;
            }
            catch (Exception exception)
            {
                LastError = exception.Message;
                _exceptionLogging.LogException("EMP001", "Employee Creation", exception);
                return false;
            }
        }

        public bool DeleteMany(Func<Employee> filter)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> FindMany(Func<Employee, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Employee FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee model)
        {
            try
            {
                // Call Entity Framework get original model
                _modelLogging.LogChanged(model, model);
                return true;
            }
            catch (Exception exception)
            {
                LastError = exception.Message;
                _exceptionLogging.LogException("EMP002", "Employee Changing", exception);
                return false;
            }
        }
    }
}