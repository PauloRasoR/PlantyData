namespace PlentyData.Models
{
    public class ProdutoCadastro
    {
        public Produto produto { get; set; }
        public ProdutoListaValor produtoListaValor { get; set; }
        public ProdutoValor produtoValor { get; set; }
        public Unidade unidade { get; set; }

    }
}
