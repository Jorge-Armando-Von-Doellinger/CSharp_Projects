using HMS.Domain.Entities;
using HMS.Domain.Interfaces.Repositories;
using HMS.Domain.Interfaces.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Task<EmployeeEntity?> CreateAsync(EmployeeEntity employee)
        {
            return _employeeRepository.CreateAsync(employee);
        }

        public async Task<int> DeleteAsync(EmployeeEntity employee)
        {
            int rowsAffected = await _employeeRepository.DeleteAsync(employee);
            return rowsAffected;
        }

        public async Task<List<EmployeeEntity>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        public async Task<EmployeeEntity?> GetByCPFAsync(Int64 CPF)
        {
            return await _employeeRepository.GetByCPFAsync(CPF);
        }
        public async Task<List<EmployeeEntity>> GetByNameAsync(EmployeeEntity employee)
        {
            return await _employeeRepository.GetByNameAsync(employee);
        }

        public async Task<EmployeeEntity?> GetByIdAsync(Int64 ID)
        {
            return await _employeeRepository.GetByIdAsync(ID);
        }

        public async Task<EmployeeEntity?> UpdateAsync(EmployeeEntity employee)
        {
            return await _employeeRepository.UpdateAsync(employee);
        }
    }
}
