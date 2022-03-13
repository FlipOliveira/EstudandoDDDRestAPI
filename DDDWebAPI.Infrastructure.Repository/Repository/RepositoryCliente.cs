using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastructure.Data;

namespace DDDWebAPI.Infrastructure.Repository.Repository
{
  
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _context;

        public RepositoryCliente(SqlContext context)
            : base(context)
        {
            _context = context;
        }
     }
}
