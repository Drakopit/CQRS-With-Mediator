using CQRS.Domain.Products;
using MediatR;

namespace CQRS.Domain.Queries
{
    public record GetAllProductsQuery : IRequest<List<Product>> {}
}
