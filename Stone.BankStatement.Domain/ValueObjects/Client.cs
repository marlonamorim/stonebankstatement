using Stone.BankStatement.Domain.Enums;

namespace Stone.BankStatement.Domain.ValueObjects
{
    public class Client
    {
        public int Id { get; set; }
        public KindPerson Type { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }

        public override string ToString() =>
            $"{Name} {LastName}";
    }
}
