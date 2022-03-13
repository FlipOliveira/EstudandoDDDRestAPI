using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Models;
using DDDWebAPI.Infrastructure.Data;

namespace DDDWebAPI.Infrastructure.Repository.Repository
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext _context;

        public RepositoryProduto(SqlContext context)
            : base(context)
        {
            _context = context;
        }
     }
}
