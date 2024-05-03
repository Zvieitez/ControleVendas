using System.ComponentModel.DataAnnotations;
using System.Data;

namespace SistControleVendas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string NomeCliente { get; set; }

        [Display(Name = "Data Cadastro")]
        [DataType(DataType.Date)]
        public DateTime DtCad { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        public string? Tel { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "O campo E-mail não é um endereço válido.")]
        public string? Email { get; set; }

        [Display(Name = "Rua")]
        public string Endereco { get; set; }

        [Display(Name = "Nº")]
        public int Num { get; set; }

        [Display(Name = "Complemento")]
        public string? Comp { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

    }

}
