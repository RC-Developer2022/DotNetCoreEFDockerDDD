using DotNetCoreEFDockerDDD.Application.Dtos;
using DotNetCoreEFDockerDDD.Domain.Entitys;

namespace DotNetCoreEFDockerDDD.Infrastructure.CrossCutting.Interfaces;

public interface IMapperProducts
{
    Products MapperDtoToEntity(ProductsDto productsDto);
    IEnumerable<ProductsDto> MapperListCustomersDto(IEnumerable<Products> products);
    ProductsDto MapperEntityToDto(Products products);
}
