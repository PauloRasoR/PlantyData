using Microsoft.EntityFrameworkCore;
using PlentyData.Data;
using PlentyData.Models;
using PlentyData.Services.Exceptions;

namespace PlentyData.Services
{
    public class EmpresaService
    {
        private readonly PlentyDataContext _context;

        public EmpresaService(PlentyDataContext context)
        {
            _context = context;
        }

        public List<Empresa> FindAll()
        {
            return _context.Empresa.ToList();
        }

        public void Insert(Empresa obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Empresa FindById(int id)
        {
            return _context.Empresa.FirstOrDefault(empresa => empresa.Id == id);
        }

        public void Update(Empresa empresa)
        {
            if (!_context.Empresa.Any(x => x.Id == empresa.Id))
            {
                throw new NotFoundException("Produto Não Encontrado");
            }
            try
            {
                _context.Update(empresa);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
