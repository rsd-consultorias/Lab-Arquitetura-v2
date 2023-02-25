using System;
using Core.Models;
using Core.Types;

namespace HR.Domain.Models
{
    public class Employee : BaseModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalId { get; set; }
        public Money CurrentSalary { get; set; }
        public string CostCenter { get; set; }

        public Employee()
        {
        }
    }
}

