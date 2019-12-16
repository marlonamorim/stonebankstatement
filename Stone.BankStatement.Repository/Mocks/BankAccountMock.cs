using System;
using System.Collections.Generic;
using System.Linq;
using Stone.BankStatement.Domain.Entities;
using Stone.BankStatement.Domain.Enums;
using Stone.BankStatement.Domain.ValueObjects;

namespace Stone.BankStatement.Repository.Mocks
{
    public class BankAccountMock
    {
        private readonly IList<BankAccount> _banksAccounts;
        public IReadOnlyCollection<BankAccount> BanksAccounts { get { return _banksAccounts.ToArray(); } }

        public BankAccountMock() =>
            _banksAccounts = new List<BankAccount>();

        public List<BankAccount> List()
        {
            var bankAccount = new BankAccount();
            var address = new Address();
            var owner = new Client();
            var bankTransaction = new BankTransaction();

            address.City = "Rio de Janeiro";
            address.Complement = "Vila Nova";
            address.Street = "Rua Argoin";
            address.Number = 55;
            address.Neighborhood = "Campo Grande";
            address.Country = "Brasil";

            owner.Name = "Marlon";
            owner.LastName = "Graciano Machado de Amorim";
            owner.Type = (KindPerson)1;
            owner.CPF = "23412890381";

            bankTransaction.AddDateTransaction(DateTime.Now);
            bankTransaction.AddTransactionAmount(1000);

            bankAccount.AddAccountNumber(123456);
            bankAccount.AddAgencyNumber(1234);
            bankAccount.AddType(1);
            bankAccount.AddAddress(address);
            bankAccount.AddOwner(owner);
            bankAccount.AddbankTransaction(bankTransaction);

            _banksAccounts.Add(bankAccount);

            return _banksAccounts.ToList();
        }
    }
}