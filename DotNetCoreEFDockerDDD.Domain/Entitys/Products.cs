using DotNetCoreEFDockerDDD.Domain.Entitys.Base;

namespace DotNetCoreEFDockerDDD.Domain.Entitys;

public class Products : EntityBase
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
}
