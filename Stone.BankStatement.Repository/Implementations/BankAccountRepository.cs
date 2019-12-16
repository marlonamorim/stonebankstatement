using Stone.BankStatement.Domain.Repositories;
using Stone.BankStatement.Domain.Entities;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Stone.BankStatement.Repository.Mocks;

namespace Stone.BankStatement.Repository.Implemations
{
    public class BankAccountRepository : IBankAccountRepository
    {
        public Task<List<BankAccount>> GetByDate(DateTime? dateIni, DateTime? dateEnd)
        {
            return Task.Run(() =>
            {
                var mock = new BankAccountMock();
                var banksAccounts = mock.List();

                if(dateIni.HasValue && !dateEnd.HasValue)
                    banksAccounts = banksAccounts.Where(doc => doc.BankTransactions.Any(x => x.DateTransaction.Date >= dateIni.Value.Date)).ToList();

                if(!dateIni.HasValue && dateEnd.HasValue)
                    banksAccounts = banksAccounts.Where(doc => doc.BankTransactions.Any(x => x.DateTransaction.Date <= dateEnd.Value.Date)).ToList();

                if(dateIni.HasValue && dateEnd.HasValue)
                    banksAccounts = banksAccounts.Where(doc => doc.BankTransactions.Any(x => x.DateTransaction.Date >= dateIni.Value.Date && x.DateTransaction.Date <= dateEnd.Value)).ToList();

                return banksAccounts;
            });
        }
    }
}
