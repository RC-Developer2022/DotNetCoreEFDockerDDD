using DotNetCoreEFDockerDDD.Domain.Entitys.Base;

namespace DotNetCoreEFDockerDDD.Domain.Entitys;

public class Customers : EntityBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateRegister { get; set; }
    public bool IsActive { get; set; } 
}
