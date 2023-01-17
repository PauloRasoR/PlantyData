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
        public bool Ativo { get; set; }
        public ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
        public ICollection<Unidade> Unidades { get; set; } = new List<Unidade>();
        public ICollection<ProdutoListaValor> ProdutoListaValores { get; set; } = new List<ProdutoListaValor>();
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

        public void AddEmpresa(Empresa _empresa)
        {
            Empresas.Add(_empresa);
        }

        public void RemoveEmpresa(Empresa _empresa)
        {
            Empresas.Remove(_empresa);
        }

        public void AddUnidade(Unidade _unidade)
        {
            Unidades.Add(_unidade);
        }

        public void RemoveUnidade(Unidade _unidade)
        {
            Unidades.Remove(_unidade);
        }

        public void AddProdutoListaValor(ProdutoListaValor _produtoListaValor)
        {
            ProdutoListaValores.Add(_produtoListaValor);
        }

        public void RemoveProdutoListaValor(ProdutoListaValor _produtoListaValor)
        {
            ProdutoListaValores.Remove(_produtoListaValor);
        }
    }
}
