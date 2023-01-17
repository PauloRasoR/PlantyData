namespace PlentyData.Models
{
    public class ProdutoListaValor
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public ProdutoListaValor()
        {

        }

        public ProdutoListaValor(int id, string nome, bool ativo)
        {
            this.id = id;
            this.Nome = nome;
            Ativo = ativo;
        }
    }
}
