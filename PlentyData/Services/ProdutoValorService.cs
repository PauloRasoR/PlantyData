using PlentyData.Data;
using PlentyData.Models;

namespace PlentyData.Services
{
    public class ProdutoValorService
    {
        private readonly PlentyDataContext _context;

        public ProdutoValorService(PlentyDataContext context)
        {
            _context = context;
        }

        public List<ProdutoValor> FindAll()
        {
            return _context.ProdutoValor.ToList();
        }

        public void Insert(ProdutoValor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
