using MediatR;

namespace Library.Application.Features.BookFeatures.UpdateBook;

public sealed record UpdateBookRequest(Guid Id, string Title, string Author, string Genre) : IRequest<UpdateBookResponse>;
