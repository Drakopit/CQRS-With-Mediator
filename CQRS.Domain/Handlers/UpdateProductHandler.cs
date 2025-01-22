using CQRS.Domain.Commands;
using CQRS.Domain.Products;
using MediatR;

namespace CQRS.Domain.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _repository;

        public UpdateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price
            };
            return await _repository.UpdateAsync(product);
        }
    }
}
