using CQRS.Domain.Products;
using MediatR;

namespace CQRS.Domain.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
