using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys;
using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Services;
using DotNetCoreEFDockerDDD.Domain.Entitys;
using DotNetCoreEFDockerDDD.Domain.Services.Services.Base;

namespace DotNetCoreEFDockerDDD.Domain.Services.Services;

public class ServiceProducts : ServiceBase<Products>, IServiceProducts
{
    private readonly IRepositoryProducts _repositoryProducts;
    public ServiceProducts(IRepositoryProducts repositoryProducts) : base(repositoryProducts)
    {
        _repositoryProducts = repositoryProducts;
    }
}
