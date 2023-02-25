using HR.Domain.Models;

namespace HR.Domain.Interfaces {
    public interface IPayrollService {
        public string LastError { get; set; }
        
        bool StartProfileCreation(Employee employee);
    }
}