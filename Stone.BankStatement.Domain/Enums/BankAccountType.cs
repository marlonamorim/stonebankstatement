using System.ComponentModel;

namespace Stone.BankStatement.Domain.Enums
{
    public enum BankAccountType
    {
        [Description("Conta Poupança")]
        SavingsAccount = 1,
        
        [Description("Conta Corrente")]
        CheckingAccount = 2
    }
}
