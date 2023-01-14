using PlentyData.Data;
using PlentyData.Models;

namespace PlentyData.Services
{
    public class ProdutoService
    {
        private readonly PlentyDataContext _context;

        public ProdutoService(PlentyDataContext context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.ToList();
        }

        public void Insert(Produto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
