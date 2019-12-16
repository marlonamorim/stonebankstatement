using System;
using Newtonsoft.Json;

namespace Stone.BankStatement.WebApi.Models
{
    public class BankTransactionModel
    {
        [JsonProperty]
        public int Id { get; set; }
        
        [JsonProperty]
        public DateTime DateTransaction { get; set; }
        
        [JsonProperty]
        public decimal TransactionAmount { get; set; }
    }
}
