using DotNetCoreEFDockerDDD.Domain.Entitys;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreEFDockerDDD.Infrastructure.Data;

public class SqlContext : DbContext
{
    public SqlContext(){}

    public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

    public DbSet<Customers> Customers { get; set; }
    public DbSet<Products> Products { get; set; }

    public override int SaveChanges()
    {
        foreach (var entry in ChangeTracker.Entries().Where(entry => entry.GetType().GetProperty("DateRegister") != null))
        {
            if (entry.State == EntityState.Added)
                entry.Property("DateRegister").CurrentValue = DateTime.Now;
            if (entry.State == EntityState.Modified)
                entry.Property("DateRegister").IsModified = false;
        }
        return base.SaveChanges();
    }

}
