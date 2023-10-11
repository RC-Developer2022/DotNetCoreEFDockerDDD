using DotNetCoreEFDockerDDD.Application.Dtos;
using DotNetCoreEFDockerDDD.Domain.Entitys;
using DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Interfaces;

namespace DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Map;

public class MapperProducts : IMapperProducts
{
    // I will finish it the next day
    public Products MapperDtoToEntity(ProductsDto productsDto)
    {
        throw new NotImplementedException();
    }

    public ProductsDto MapperEntityToDto(Products products)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ProductsDto> MapperListCustomersDto(IEnumerable<Products> products)
    {
        throw new NotImplementedException();
    }
}
