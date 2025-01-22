using CQRS.Domain.Products;
using CQRS.Domain.Queries;
using MediatR;

namespace CQRS.Domain.Handlers
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, Product>
    {
        private readonly IProductRepository _repository;

        public GetProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(request.Id);
        }
    }

}
