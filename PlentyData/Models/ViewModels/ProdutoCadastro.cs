namespace PlentyData.Models.ViewModels
{
    public class ProdutoCadastro
    {
        public Produto produto { get; set; }
        public ProdutoListaValor produtoListaValor { get; set; }
        public ProdutoValor produtoValor { get; set; }
        public ICollection<Empresa> empresa { get; set; }
        public ICollection<Unidade> unidade { get; set; }

    }
}
