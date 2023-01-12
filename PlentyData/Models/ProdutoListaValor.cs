namespace PlentyData.Models
{
    public class ProdutoListaValor
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Boolean Ativo { get; set; }

        public ProdutoListaValor()
        {

        }

        public ProdutoListaValor(int id, string nome, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            Ativo = ativo;
        }
    }
}
