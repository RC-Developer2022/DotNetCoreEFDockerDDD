using DotNetCoreEFDockerDDD.Application.Dtos;
using DotNetCoreEFDockerDDD.Application.Interfaces;

namespace DotNetCoreEFDockerDDD.Application.Services;

public class ApplicationServiceCustomers : IApplicationServiceCustomers
{
    public void Add(CustomersDto customersDto)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomersDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<CustomersDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(CustomersDto customersDto)
    {
        throw new NotImplementedException();
    }

    public void Update(CustomersDto customersDto)
    {
        throw new NotImplementedException();
    }
}
