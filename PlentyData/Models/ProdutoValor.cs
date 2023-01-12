namespace PlentyData.Models
{
    public class ProdutoValor
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int ProdutoListaValorId { get; set; }
        public int EmpresaId { get; set; }
        public int UnidadeId { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal ValorCustoMedio { get; set; }
        public decimal PercentualLucro { get; set; }
        public decimal ValorVenda { get; set; }
        public Boolean Ativo { get; set; }

        public ProdutoValor()
        {

        }

        public ProdutoValor(int id, int produtoId, int produtoListaValorId, int empresaId, int unidadeId, decimal valorCompra, decimal valorCusto, decimal valorCustoMedio, decimal percentualLucro, decimal valorVenda, bool ativo)
        {
            Id = id;
            ProdutoId = produtoId;
            ProdutoListaValorId = produtoListaValorId;
            EmpresaId = empresaId;
            UnidadeId = unidadeId;
            ValorCompra = valorCompra;
            ValorCusto = valorCusto;
            ValorCustoMedio = valorCustoMedio;
            PercentualLucro = percentualLucro;
            ValorVenda = valorVenda;
            Ativo = ativo;
        }
    }
}
