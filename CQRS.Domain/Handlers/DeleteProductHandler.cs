using CQRS.Domain.Commands;
using CQRS.Domain.Products;
using MediatR;

namespace CQRS.Domain.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IProductRepository _repository;

        public DeleteProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteAsync(request.Id);
        }
    }
}
