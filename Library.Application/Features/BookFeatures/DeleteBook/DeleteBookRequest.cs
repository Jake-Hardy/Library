using MediatR;

namespace Library.Application.Features.BookFeatures.DeleteBook;

public sealed record DeleteBookRequest(Guid Id) : IRequest<DeleteBookResponse>;
