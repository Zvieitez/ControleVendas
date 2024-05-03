using System.ComponentModel.DataAnnotations;

namespace SistControleVendas.Models
{
    public class Colaborador
    {
        public int ColaboradorID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "CPF")]
        public string? Cpf { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "O campo E-mail não é um endereço de e-mail válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Telefone { get; set; }

        [Required]
        public string Cargo { get; set; }

        [Display(Name = "Data de Contratação")]
        [DataType(DataType.Date)]
        public DateTime? DtContratacao { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Salario { get; set; }

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
