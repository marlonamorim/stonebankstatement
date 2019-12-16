using System.Collections.Generic;
using System.Linq;
using Stone.BankStatement.Domain.Enums;
using Stone.BankStatement.Domain.ValueObjects;

namespace Stone.BankStatement.Domain.Entities
{
    public class BankAccount
    {
        IList<BankTransaction> _bankTransaction;

        public BankAccount()
        {
            _bankTransaction = new List<BankTransaction>();
        }

        public int Id { get; private set; }
        public BankAccountType Type { get; private set; }
        public Address Address { get; private set; }
        public int AgencyNumber { get; private set; }
        public int AccountNumber { get; private set; }
        public Client Owner { get; private set; }
        public IReadOnlyCollection<BankTransaction> BankTransactions { get { return _bankTransaction.ToArray(); } }

        public void AddType(int type) =>
            Type = (BankAccountType)type;
        public void AddAddress(Address address) =>
            Address = address;
        public void AddAgencyNumber(int agencyNumber) =>
            AgencyNumber = agencyNumber;
        public void AddAccountNumber(int accountNumber) =>
            AccountNumber = accountNumber;
        public void AddOwner(Client owner) =>
            Owner = owner;
        public void AddbankTransaction(BankTransaction bankTransaction) =>
            _bankTransaction.Add(bankTransaction);
    }
}
