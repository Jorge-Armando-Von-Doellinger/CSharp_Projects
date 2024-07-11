using HMS.Domain.Interfaces.Repositories;
using HMS.Infrastructure.Contexts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public UnitOfWork(Context context)
        {
            _context = context;
        }
        public async Task<int> ExecuteInTransactionAsync()
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var rowsAffected = await _context.SaveChangesAsync();
                    if(rowsAffected != 1)
                    {
                        throw new Exception("Erro ao durante o salvamento!");
                    }
                    await transaction.CommitAsync();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    Console.WriteLine(ex.Message);
                    return 0;   
                }
            }
        }
    }
}
