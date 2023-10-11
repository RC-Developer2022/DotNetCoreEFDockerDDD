using DotNetCoreEFDockerDDD.Application.Dtos;
using DotNetCoreEFDockerDDD.Domain.Entitys;

namespace DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Interfaces;

public interface IMapperCustomers
{
    Customers MapperDtoToEntity(CustomersDto customersDto);
    IEnumerable<CustomersDto> MapperListCustomersDto (IEnumerable<Customers> customers);
    CustomersDto MapperEntityToDto(Customers customers);
}
