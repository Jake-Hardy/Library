using MediatR;

namespace Library.Application.Features.BookFeatures.CreateBook;

public sealed record CreateBookRequest(string Title, string Author, string Genre) : IRequest<CreateBookResponse>;
