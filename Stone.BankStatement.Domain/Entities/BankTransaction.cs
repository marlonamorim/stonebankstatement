using System;

namespace Stone.BankStatement.Domain.Entities
{
    public class BankTransaction
    {
        public int Id { get; private set; }
        public DateTime DateTransaction { get; private set; }
        public decimal TransactionAmount { get; private set; }

        public void AddDateTransaction(DateTime dateTransaction) =>
            DateTransaction = dateTransaction;
        public void AddTransactionAmount(decimal transactionAmount) =>
            TransactionAmount = transactionAmount;
    }
}
