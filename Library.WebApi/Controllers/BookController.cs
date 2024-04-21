using Library.Application.Features.BookFeatures.CreateBook;
using Library.Application.Features.BookFeatures.DeleteBook;
using Library.Application.Features.BookFeatures.GetAllBook;
using Library.Application.Features.BookFeatures.UpdateBook;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebApi.Controllers
{
    [Route("api/v1/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllBookResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllBookRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateBookResponse>> Create(CreateBookRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult<UpdateBookResponse>> Update(UpdateBookRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<DeleteBookResponse>> Delete(Guid id, CancellationToken cancellationToken)
        {
            DeleteBookRequest request = new DeleteBookRequest(id);
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
