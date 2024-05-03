using System.ComponentModel.DataAnnotations;

namespace SistControleVendas.Models
{
    public class Login
    {
        public int LoginID { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string? LoginNome { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Máximo de 10, mínimo de 4 caracteres")]
        public string? Senha { get; set; }

        [Required]
        public int NivelAcesso{ get; set; }
    }
}
