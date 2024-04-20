using MediatR;

namespace Library.Application.Features.BookFeatures.GetAllBook;

public sealed record GetAllBookRequest : IRequest<List<GetAllBookResponse>>;
