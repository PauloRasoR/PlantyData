using PlentyData.Models.Enuns;

namespace PlentyData.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeDocumentoFiscal { get; set; }
        public string Referencia { get; set; }
        public string Gtin { get; set; }
        public string Ncm { get; set; }
        public string Cest { get; set; }
        public TipoAgregadoEnum Tipo { get; set; }
        public bool Ativo { get; set; }
        public ICollection<ProdutoValor> ProdutoValores { get; set; } = new List<ProdutoValor>();

        public Produto()
        {

        }

        public Produto(int id, string nome, string nomeDocumentoFiscal, string referencia, string gtin, string ncm, string cest, TipoAgregadoEnum tipo, bool ativo)
        {
            Id = id;
            Nome = nome;
            NomeDocumentoFiscal = nomeDocumentoFiscal;
            Referencia = referencia;
            Gtin = gtin;
            Ncm = ncm;
            Cest = cest;
            Tipo = tipo;
            Ativo = ativo;
        }

        public void AddProdutoValor(ProdutoValor _produtovalor)
        {
            ProdutoValores.Add(_produtovalor);
        }

        public void RemoveProdutovalor(ProdutoValor _produtoValor)
        {
            ProdutoValores.Remove(_produtoValor);
        }

    }
}
