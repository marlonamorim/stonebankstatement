using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Stone.BankStatement.Domain.Enums;
using Stone.BankStatement.Domain.ValueObjects;

namespace Stone.BankStatement.WebApi.Models
{
    public class BankAccountModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [JsonProperty]
        public BankAccountType Type { get; set; }
        
        [Required]
        [JsonProperty]
        public AddressModel Address { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Range(0000, 9999, ErrorMessage = "Este campo deve conter 4 caracteres")]
        [JsonProperty]
        public int AgencyNumber { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Range(00000, 99999, ErrorMessage = "Este campo deve conter 5 caracteres")]
        [JsonProperty]
        public int AccountNumber { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [JsonProperty]
        public ClientModel Owner { get; set; }
        
        [JsonProperty]
        public List<BankTransactionModel> BankTransactions { get; set; }
    }
}
