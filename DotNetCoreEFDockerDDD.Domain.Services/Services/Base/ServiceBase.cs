using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys.Base;
using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Services.Base;

namespace DotNetCoreEFDockerDDD.Domain.Services.Services.Base;

public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
{
    private readonly IRepositoryBase<TEntity> _repositoryBase;
    public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
    {
        _repositoryBase = repositoryBase;
    }
    public void Add(TEntity entity)
    {
        _repositoryBase.Add(entity);
    }
    public void Update(TEntity entity)
    {
        _repositoryBase.Update(entity);
    }
    public void Remove(TEntity entity)
    {
        _repositoryBase.Remove(entity);
    }
    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _repositoryBase.GetAll();
    }
    public async Task<TEntity> GetById(int id)
    {
        return await _repositoryBase.GetById(id);
    }
}
