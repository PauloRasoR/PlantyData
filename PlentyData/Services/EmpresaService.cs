using PlentyData.Data;
using PlentyData.Models;

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
    }
}
