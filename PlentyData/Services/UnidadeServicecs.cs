using PlentyData.Data;
using PlentyData.Models;

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
    }
}
