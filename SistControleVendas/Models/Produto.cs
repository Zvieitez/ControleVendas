using System.ComponentModel.DataAnnotations;

namespace SistControleVendas.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }

        [Display(Name = "Produto")]
        public string? NomeProduto { get; set; }

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Custo Unitário")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CustoUnitario { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Preço Venda")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal PrecoVenda { get; set; }

        [Required]
        public string? Fornecedor { get; set; }
    }

}

