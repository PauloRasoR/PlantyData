using Microsoft.EntityFrameworkCore;
using PlentyData.Data;
using PlentyData.Models;
using PlentyData.Services.Exceptions;

namespace PlentyData.Services
{
    public class UnidadeService
    {
        private readonly PlentyDataContext _context;

        public UnidadeService(PlentyDataContext context)
        {
            _context = context;
        }

        public List<Unidade> FindAll()
        {
            return _context.Unidade.ToList();
        }

        public void Insert(Unidade obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Unidade FindById(int id)
        {
            return _context.Unidade.FirstOrDefault(unidade => unidade.Id == id);
        }

        public void Update(Unidade unidade)
        {
            if (!_context.Unidade.Any(x => x.Id == unidade.Id))
            {
                throw new NotFoundException("Produto Não Encontrado");
            }
            try
            {
                _context.Update(unidade);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
