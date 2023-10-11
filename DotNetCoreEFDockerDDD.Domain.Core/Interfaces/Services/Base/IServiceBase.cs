namespace DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Services.Base;

public interface IServiceBase<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> GetById(int id);
}
