using MediatR;

namespace CQRS.Domain.Commands
{
    public class UpdateProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
