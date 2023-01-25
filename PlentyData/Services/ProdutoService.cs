using Microsoft.EntityFrameworkCore;
using PlentyData.Data;
using PlentyData.Models;
using PlentyData.Services.Exceptions;

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

        public void Insert(Produto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
        }

        public Produto FindById(int id)
        {
            return _context.Produto.FirstOrDefault(produto => produto.Id == id);
        }

        public void Update(Produto produto)
        {
            if (!_context.Produto.Any(x => x.Id == produto.Id))
            {
                throw new NotFoundException("Produto Não Encontrado");
            }
            try
            {
                _context.Update(produto);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

    }
}
