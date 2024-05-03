using System.ComponentModel.DataAnnotations;

namespace SistControleVendas.Models
{
    public class FormaPagto
    { 
            public int FormaPagtoID { get; set; }

            [Display(Name = "Cartão de Crédito")]
            public string? CartaoCred { get; set; }

            [Display(Name = "Cartão de Débito")]
            public string? CartaoDeb { get; set; }

            [Display(Name = "PIX")]
            public string? Pix { get; set; }
        }


    }


