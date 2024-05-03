using System.ComponentModel.DataAnnotations;

namespace SistControleVendas.Models
{
    public class NivelAcesso
    {
        public int NivelAcessoID { get; set; }

        [Required]
        [Display(Name = "Tipo de Acesso")]
        public string Descricao { get; set; }


    }
}
