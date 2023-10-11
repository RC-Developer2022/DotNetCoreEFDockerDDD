using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys;
using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Services;
using DotNetCoreEFDockerDDD.Domain.Entitys;
using DotNetCoreEFDockerDDD.Domain.Services.Services.Base;

namespace DotNetCoreEFDockerDDD.Domain.Services.Services;

public class ServiceCustomers : ServiceBase<Customers>, IServiceCustomers
{
    private readonly IRepositoryCustomers _repositoryCustomers;
    public ServiceCustomers(IRepositoryCustomers repositoryCustomers) : base(repositoryCustomers)
    {
        _repositoryCustomers = repositoryCustomers;
    }
}
