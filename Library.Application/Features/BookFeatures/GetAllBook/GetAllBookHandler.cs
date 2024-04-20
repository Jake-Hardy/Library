using Library.Application.Repositories;

using AutoMapper;
using MediatR;

namespace Library.Application.Features.BookFeatures.GetAllBook;

public sealed class GetAllBookHandler : IRequestHandler<GetAllBookRequest, List<GetAllBookResponse>>
{
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public GetAllBookHandler(IBookRepository bookRepository, IMapper mapper)
    {
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllBookResponse>> Handle(GetAllBookRequest request, CancellationToken cancellationToken)
    {
        var books = await _bookRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllBookResponse>>(books);
    }
}
