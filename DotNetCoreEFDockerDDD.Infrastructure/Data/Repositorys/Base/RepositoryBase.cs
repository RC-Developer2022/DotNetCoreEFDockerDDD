using DotNetCoreEFDockerDDD.Domain.Core.Interfaces.Repositorys.Base;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreEFDockerDDD.Infrastructure.Data.Repositorys;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    private readonly SqlContext _sqlContext;

    public RepositoryBase(SqlContext sqlContext)
    {
        _sqlContext = sqlContext;
    }

    public void Add(TEntity entity)
    {
        try
        {
            _sqlContext.Set<TEntity>().Add(entity);
            _sqlContext.SaveChanges();
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }

    public void Update(TEntity entity)
    {
        try
        {
            _sqlContext.Entry(entity).State = EntityState.Modified;
            _sqlContext.SaveChanges();
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }

    public void Remove(TEntity entity)
    {
        try
        {
            _sqlContext.Set<TEntity>().Remove(entity);
            _sqlContext.SaveChanges();
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _sqlContext.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetById(int id)
    {
        return await _sqlContext.Set<TEntity>().FindAsync(id);
    }
}
