using DDDWebAPI.Domain.Core.Interfaces.Repositorys;
using DDDWebAPI.Domain.Core.Interfaces.Services;
using DDDWebAPI.Domain.Models;

namespace DDDWebAPI.Domain.Services.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryPorduto;
        public ServiceProduto(IRepositoryProduto RepositoryProduto)
            : base(RepositoryProduto)
        {
            _repositoryPorduto = RepositoryProduto;
        }
    }
}
