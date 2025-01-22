using CQRS.Domain.Products;
using MediatR;

namespace CQRS.Domain.Queries
{
    public record GetProductQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }

}
