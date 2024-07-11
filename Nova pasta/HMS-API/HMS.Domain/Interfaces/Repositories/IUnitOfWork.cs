using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        public Task<int> ExecuteInTransactionAsync();
    }
}
