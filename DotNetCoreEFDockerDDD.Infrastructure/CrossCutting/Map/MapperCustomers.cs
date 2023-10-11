using DotNetCoreEFDockerDDD.Application.Dtos;
using DotNetCoreEFDockerDDD.Domain.Entitys;
using DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Interfaces;

namespace DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Map;

public class MapperCustomers : IMapperCustomers
{
    IEnumerable<CustomersDto> customersDtos = new List<CustomersDto>();
    public Customers MapperDtoToEntity(CustomersDto customersDto)
    {
        var customers = new Customers()
        {
            Id = customersDto.Id,
            FirstName = customersDto.FirstName,
            LastName = customersDto.LastName,
            Email = customersDto.Email
        };

        return customers;
    }

    public CustomersDto MapperEntityToDto(Customers customers)
    {
        var customersDto = new CustomersDto()
        {
            Id = customers.Id,
            FirstName = customers.FirstName,
            LastName = customers.LastName,
            Email = customers.Email
        };
        return customersDto;
    }

    public IEnumerable<CustomersDto> MapperListCustomersDto(IEnumerable<Customers> customers)
    {
        var dto = customers.Select(c => new CustomersDto()
        {
            Id = c.Id,
            FirstName = c.FirstName,
            LastName = c.LastName,
            Email = c.Email
        });
        return dto;
    }
}
