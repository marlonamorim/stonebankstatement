using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Stone.BankStatement.Domain.Entities;

namespace Stone.BankStatement.Domain.Repositories
{
    public interface IBankAccountRepository
    {
        Task<List<BankAccount>> GetByDate(DateTime? dateIni, DateTime? dateEnd);
    }
}
