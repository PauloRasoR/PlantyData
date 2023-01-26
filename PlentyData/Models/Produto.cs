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
        public string Nome { get; set; }
        public string NomeDocumentoFiscal { get; set; }
        public string Referencia { get; set; }
        public string Gtin { get; set; }
        public string Ncm { get; set; }
        public string Cest { get; set; }
        public Unidade Unidade { get; set; }
        public int UnidadeId { get; set; }
        public TipoAgregadoEnum TipoProduto { get; set; }
        public int TipoProdutoId { get; set; } 
        public decimal ValorCompra { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorCustoMedio { get; set; }
        public decimal PercentualLucro { get; set; }
        public decimal ValorVenda { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Unidade> unidade { get; set; } = new List<Unidade>();
        [NotMapped]
        public IEnumerable<SelectListItem> tipoProduto { get; set; } 

        public Produto()
        {

        }

        public Produto(int id, string nome, string nomeDocumentoFiscal, string referencia, string gtin, string ncm, string cest, bool ativo)
        {
            Id = id;
            Nome = nome;
            NomeDocumentoFiscal = nomeDocumentoFiscal;
            Referencia = referencia;
            Gtin = gtin;
            Ncm = ncm;
            Cest = cest;
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
