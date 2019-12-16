using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Stone.BankStatement.Domain.Enums;

namespace Stone.BankStatement.WebApi.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [JsonProperty]
        public KindPerson Type { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [JsonProperty]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [MinLength(10, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [JsonProperty]
        public string LastName { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }

        public override string ToString() =>
            $"{Name} {LastName}";
    }
}
