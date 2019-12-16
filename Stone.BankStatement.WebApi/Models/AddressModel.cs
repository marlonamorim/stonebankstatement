using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Stone.BankStatement.WebApi.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [MinLength(10, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [JsonProperty]
        public string Street { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [JsonProperty]
        public int Number { get; set; }
        
        [JsonProperty]
        public string Complement { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [MinLength(10, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [JsonProperty]
        public string Neighborhood { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [MinLength(5, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [JsonProperty]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [MinLength(5, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [JsonProperty]
        public string Country { get; set; }
    }
}
