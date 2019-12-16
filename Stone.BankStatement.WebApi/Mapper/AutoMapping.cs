using AutoMapper;
using Stone.BankStatement.Domain.Entities;
using Stone.BankStatement.Domain.ValueObjects;
using Stone.BankStatement.WebApi.Models;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<BankTransaction, BankTransactionModel>();
        CreateMap<Address, AddressModel>();
        CreateMap<Client, ClientModel>();
        CreateMap<BankAccount, BankAccountModel>();
    }
}