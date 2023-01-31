using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlentyData.Models.Enum;

namespace PlentyData.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição *")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição Documento Fiscal *")]
        public string NomeDocumentoFiscal { get; set; }

        [Required]
        [Display(Name = "Referência")]
        public string Referencia { get; set; }

        [Required]
        [Display(Name = "Código de Barras (EAN) *")]
        public string Gtin { get; set; }

        [Required(ErrorMessage ="Deve ser informado um código NCM")]       
        [Display(Name = "Código NCM *")]
        public string Ncm { get; set; }

        [Required(ErrorMessage = "Deve ser informado um código CEST")]
        [Display(Name = "Código CEST *")]
        public string Cest { get; set; }
        public Unidade Unidade { get; set; }

        [Required]
        [Display(Name = "Unidade")]
        public int UnidadeId { get; set; }
        public TipoAgregadoEnum TipoProduto { get; set; }

        [Required]
        [Display(Name = "Tipo de Produto")]
        public int TipoProdutoId { get; set; }

        [Required]
        [Display(Name = "Compra")]
        public decimal ValorCompra { get; set; }

        [Display(Name = "Custo")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal ValorCusto { get; set; }

        [Required]
        [Display(Name = "Custo Médio")]
        public decimal ValorCustoMedio { get; set; }
        
        [Display(Name = "% Lucro")]
        public decimal PercentualLucro { get; set; }

        [Required(ErrorMessage = "Deve ser informado valor de venda maior que 0,00")]
        [Display(Name = "Venda")]
        public decimal ValorVenda { get; set; }

        [Display(Name = "Quantidade Entrada")]
        public decimal EstoqueEntrada { get; set; }

        [Display(Name = "Quantidade Saída")]
        public decimal EstoqueSaida { get; set; }

        [Display(Name = "Quantidade Saldo")]
        public decimal EstoqueSaldo { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Unidade> unidade { get; set; } = new List<Unidade>();
        [NotMapped]
        public IEnumerable<SelectListItem> tipoProduto { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, string nomeDocumentoFiscal, string referencia, string gtin, string ncm, string cest, int unidadeId, int tipoProdutoId, decimal valorCompra, decimal valorCusto, decimal valorCustoMedio, decimal percentualLucro, decimal valorVenda, decimal estoqueEntrada, decimal estoqueSaida, decimal estoqueSaldo, bool ativo)
        {
            Id = id;
            Nome = nome;
            NomeDocumentoFiscal = nomeDocumentoFiscal;
            Referencia = referencia;
            Gtin = gtin;
            Ncm = ncm;
            Cest = cest;
            UnidadeId = unidadeId;
            TipoProdutoId = tipoProdutoId;
            ValorCompra = valorCompra;
            ValorCusto = valorCusto;
            ValorCustoMedio = valorCustoMedio;
            PercentualLucro = percentualLucro;
            ValorVenda = valorVenda;
            EstoqueEntrada = estoqueEntrada;
            EstoqueSaida = estoqueSaida;
            EstoqueSaldo = estoqueSaldo;
            Ativo = ativo;
        }

        public void AddUnidade(Unidade _unidade)
        {
            unidade.Add(_unidade);
        }

        public void RemoveUnidade(Unidade _unidade)
        {
            unidade.Remove(_unidade);
        }
    }
}
