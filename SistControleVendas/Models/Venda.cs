using System.ComponentModel.DataAnnotations;

namespace SistControleVendas.Models
{
    public class Venda
    {
        public int VendaID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "ID do Colaborador")]
        public int ColaboradorID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "ID do Cliente")]
        public int ClienteID { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data da Venda")]
        public DateTime DataVenda { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string? Produto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Quantidade")]
        public int Qtde { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Valor Unitário")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Total da Venda")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalVenda { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Forma de Pagamento")]
        public string? FormaPgto { get; set; }

    }
}
