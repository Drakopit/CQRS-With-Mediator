using CQRS.Domain.Commands;
using CQRS.Domain.Products;
using MediatR;

namespace CQRS.Domain.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price,
            };
            await _repository.AddAsync(product);
            return product.Id;
        }
    }
}
