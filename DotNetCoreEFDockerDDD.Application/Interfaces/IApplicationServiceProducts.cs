using DotNetCoreEFDockerDDD.Application.Dtos;

namespace DotNetCoreEFDockerDDD.Application.Interfaces;

public interface IApplicationServiceProducts
{
    void Add(ProductsDto productsDto);
    void Update(ProductsDto productsDto);
    void Remove(ProductsDto productsDto);
    Task<IEnumerable<ProductsDto>> GetAll();
    Task<ProductsDto> GetById(int id);
}
