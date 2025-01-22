using MediatR;

namespace CQRS.Domain.Commands
{
    public record CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
