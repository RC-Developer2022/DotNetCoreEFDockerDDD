using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys;
using DotNetCoreEFDockerDDD.Domain.Entitys;

namespace DotNetCoreEFDockerDDD.Infrastructure.Data.Repositorys;

public class RepositoryCustomers : RepositoryBase<Customers>, IRepositoryCustomers
{
    private readonly SqlContext _sqlContext;
    public RepositoryCustomers(SqlContext sqlContext) : base(sqlContext)
    {
        _sqlContext = sqlContext;
    }
}
