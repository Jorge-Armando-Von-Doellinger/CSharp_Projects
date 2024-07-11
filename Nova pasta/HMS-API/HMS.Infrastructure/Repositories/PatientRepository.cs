using HMS.Domain.Entities;
using HMS.Domain.Interfaces.Repositories;
using HMS.Infrastructure.BaseRepository;
using HMS.Infrastructure.Contexts;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure.Repositories
{
    public class PatientRepository :  RepositoryBase<PatientEntity>, IPatientRepository
    {
        //Ta meio gambiarra, mas...... Proximo projeto sai melhor!
        public Context _context { get; set; }
        private IUnitOfWork _unitOfWork;

        public PatientRepository(Context context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
        public async Task<PatientEntity?> UpdateAsync(PatientEntity entity)
        {
            PatientEntity? existingEntity = await _context.Set<PatientEntity>().FindAsync(entity.ID);
            if(existingEntity != null)
            {
                entity.CreatedAt = entity.CreatedAt;
                entity.UpdatedAt = DateTime.Now.ToLocalTime();
                await Task.Delay(1);
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
                if (await _unitOfWork.ExecuteInTransactionAsync() == 1)
                    return existingEntity;
            }
            return default;
        }
        public async Task<PatientEntity?> GetByCPFAsync(Int64 CPF)
        {
            return await _context.Patients.AsNoTracking().FirstOrDefaultAsync(e => e.CPF == CPF);
        }

        public async Task<List<PatientEntity>> GetByNameAsync(PatientEntity patient)
        {
            return await _context.Patients
                .AsNoTracking()
                .Where(e =>
        (patient.FirstName != null && patient.LastName != null &&
         e.FirstName.Contains(patient.FirstName) && e.LastName.Contains(patient.LastName)) ||
        (patient.FirstName != null && patient.LastName == null &&
         (e.FirstName.Contains(patient.FirstName) || e.LastName.Contains(patient.FirstName))) ||
        (patient.FirstName == null && patient.LastName != null &&
         e.FirstName.Contains(patient.LastName))
                )           
                .ToListAsync();
        }
    }
}


