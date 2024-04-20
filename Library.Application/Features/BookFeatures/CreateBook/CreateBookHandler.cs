using AutoMapper;
using Library.Application.Repositories;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Features.BookFeatures.CreateBook;

public sealed class CreateBookHandler : IRequestHandler<CreateBookRequest, CreateBookResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public CreateBookHandler(IUnitOfWork unitOfWork, IBookRepository bookRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<CreateBookResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
    {
        var book = _mapper.Map<Book>(request);
        _bookRepository.Create(book);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<CreateBookResponse>(book);
    }
}
