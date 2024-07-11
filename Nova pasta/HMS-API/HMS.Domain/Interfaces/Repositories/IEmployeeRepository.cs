using HMS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        public Task<List<EmployeeEntity>> GetAllAsync();
        public Task<EmployeeEntity?> GetByIdAsync(Int64 ID);
        public Task<EmployeeEntity?> CreateAsync(EmployeeEntity employee);
        public Task<EmployeeEntity?> UpdateAsync(EmployeeEntity employee);
        public Task<int> DeleteAsync(EmployeeEntity employee);
        public Task<EmployeeEntity?> GetByCPFAsync(Int64 CPF);
        public Task<List<EmployeeEntity>> GetByNameAsync(EmployeeEntity employee);
    }
}
