using CQRS.Domain.Products;
using CQRS.Domain.Queries;
using MediatR;

namespace CQRS.Domain.Handlers
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductRepository _repository;

        public GetAllProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();
        }
    }

}
