namespace DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys.Base;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    Task<IEnumerable<TEntity>> GetAll();
    Task<TEntity> GetById(int id);

}
