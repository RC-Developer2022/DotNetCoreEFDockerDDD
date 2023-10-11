using DotNetCoreEFDockerDDD.Application.Dtos;
using DotNetCoreEFDockerDDD.Domain.Entitys;
using DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Interfaces;

namespace DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Map;

public class MapperProducts : IMapperProducts
{
    IEnumerable<ProductsDto> customersDtos = new List<ProductsDto>();
    public Products MapperDtoToEntity(ProductsDto productsDto)
    {
        var customers = new Products()
        {
            Id = productsDto.Id,
            Name = productsDto.Name,
            Price = productsDto.Price
        };

        return customers;
    }

    public ProductsDto MapperEntityToDto(Products products)
    {
        var customersDto = new ProductsDto()
        {
            Id = products.Id,
            Name = products.Name,
            Price = products.Price
        };
        return customersDto;
    }

    public IEnumerable<ProductsDto> MapperListCustomersDto(IEnumerable<Products> products)
    {
        var dto = products.Select(p => new ProductsDto()
        {
            Id = p.Id,
            Name = p.Name,
            Price = p.Price
        });

        return dto;
    }
}
