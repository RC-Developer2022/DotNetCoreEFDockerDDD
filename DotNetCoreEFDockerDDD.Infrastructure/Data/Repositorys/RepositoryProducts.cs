using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys;
using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys.Base;
using DotNetCoreEFDockerDDD.Domain.Entitys;

namespace DotNetCoreEFDockerDDD.Infrastructure.Data.Repositorys;

public class RepositoryProducts : RepositoryBase<Products>, IRepositoryProducts
{
    private readonly SqlContext _sqlContext;
    public RepositoryProducts(SqlContext sqlContext) : base(sqlContext)
    {
        _sqlContext = sqlContext;
    }
}
