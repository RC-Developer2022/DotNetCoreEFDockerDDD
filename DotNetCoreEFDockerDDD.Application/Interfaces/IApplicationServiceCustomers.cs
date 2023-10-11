using DotNetCoreEFDockerDDD.Application.Dtos;

namespace DotNetCoreEFDockerDDD.Application.Interfaces;

public interface IApplicationServiceCustomers
{
    void Add(CustomersDto customersDto);
    void Update(CustomersDto customersDto);
    void Remove (CustomersDto customersDto);
    Task<IEnumerable<CustomersDto>> GetAll();
    Task<CustomersDto> GetById(int id);
}
