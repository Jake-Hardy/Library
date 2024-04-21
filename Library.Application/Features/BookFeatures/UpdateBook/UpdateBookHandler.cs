using AutoMapper;
using Library.Application.Repositories;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Features.BookFeatures.UpdateBook;

public sealed class UpdateBookHandler : IRequestHandler<UpdateBookRequest, UpdateBookResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public UpdateBookHandler(IUnitOfWork unitOfWork, IBookRepository bookRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<UpdateBookResponse> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
    {
        var book = _mapper.Map<Book>(request);
        _bookRepository.Update(book);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<UpdateBookResponse>(book);
    }
}
