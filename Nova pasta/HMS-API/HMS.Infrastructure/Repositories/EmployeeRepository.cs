using HMS.Domain.Entities;
using HMS.Domain.Interfaces.Repositories;
using HMS.Infrastructure.BaseRepository;
using HMS.Infrastructure.Contexts;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure.Repositories
{
    public class EmployeeRepository : RepositoryBase<EmployeeEntity>, IEmployeeRepository
    {
        private readonly Context _context;
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeRepository(Context context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public async Task<EmployeeEntity?> UpdateAsync(EmployeeEntity employee)
        {
            EmployeeEntity? existEmployee = await _context.Employees.FindAsync(employee.ID)
                ?? null;
            if(existEmployee != null)
            {
                if(employee.SocialIntegrationProgramNumber == 0 || employee.SocialIntegrationProgramNumber == null)
                {
                    employee.SocialIntegrationProgramNumber = existEmployee.SocialIntegrationProgramNumber;
                }
                employee.CreatedAt = existEmployee.CreatedAt;
                employee.UpdatedAt = DateTime.Now.ToLocalTime();
                await Task.Delay(1);
                _context.Entry(existEmployee).CurrentValues.SetValues(employee);
                if(await _unitOfWork.ExecuteInTransactionAsync() == 1)
                {
                    return existEmployee;
                }
            }
            return default;
        }
        public async Task<EmployeeEntity?> GetByCPFAsync(Int64 CPF)
        {
            return await _context.Employees
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.CPF == CPF);
        }

        public async Task<List<EmployeeEntity>> GetByNameAsync(EmployeeEntity employee)
        {
            return await _context.Employees
                .AsNoTracking()
                .Where(e =>
        (employee.FirstName != null && employee.LastName != null &&
         e.FirstName.Contains(employee.FirstName) && e.LastName.Contains(employee.LastName)) ||
        (employee.FirstName != null && employee.LastName == null &&
         (e.FirstName.Contains(employee.FirstName) || e.LastName.Contains(employee.FirstName))) ||
        (employee.FirstName == null && employee.LastName != null &&
         e.FirstName.Contains(employee.LastName))
                )
                .ToListAsync();
        }
    }
}
