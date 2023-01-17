using PlentyData.Data;
using PlentyData.Models;

namespace PlentyData.Services
{
    public class ProdutoListaValorService
    {
        private readonly PlentyDataContext _context;

        public ProdutoListaValorService(PlentyDataContext context)
        {
            _context = context;
        }

        public List<ProdutoListaValor> FindAll()
        {
            return _context.ProdutoListaValor.ToList();
        }

        public void Insert(ProdutoListaValor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
