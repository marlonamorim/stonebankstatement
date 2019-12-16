using System.ComponentModel;

namespace Stone.BankStatement.Domain.Enums
{
    public enum KindPerson
    {
        [Description("Pessoa Física")]
        PhysicalPerson = 1,
        
        [Description("Pessoa Jurídica")]
        LegalPerson = 2
    }
}
