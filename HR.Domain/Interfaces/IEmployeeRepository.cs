using System;
using Core.Interfaces;
using HR.Domain.Models;

namespace HR.Domain.Interfaces
{
	public interface IEmployeeRepository: IRepository<Employee>
    {
		// Specify specialized methods
	}
}

