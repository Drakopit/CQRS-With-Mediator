using CQRS.Domain.Commands;
using CQRS.Domain.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand command)
        {
            var productId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetProduct), new { id = productId }, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductCommand command)
        {
            command.Id = id;
            var success = await _mediator.Send(command);
            return success ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id, [FromBody] DeleteProductCommand command)
        {
            command.Id = id;
            var success = await _mediator.Send(command);
            return success ? NoContent() : NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id, [FromQuery] GetProductQuery query)
        {
            query.Id = id;
            var product = await _mediator.Send(query);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] GetAllProductsQuery query)
        {
            var products = await _mediator.Send(query);
            return Ok(products);
        }
    }
}
