using AutoMapper;
using Library.Application.Repositories;
using Library.Domain.Entities;
using MediatR;

namespace Library.Application.Features.BookFeatures.DeleteBook;

public sealed class DeleteBookHandler : IRequestHandler<DeleteBookRequest, DeleteBookResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;

    public DeleteBookHandler(IUnitOfWork unitOfWork, IBookRepository bookRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _bookRepository = bookRepository;
        _mapper = mapper;
    }

    public async Task<DeleteBookResponse> Handle(DeleteBookRequest request, CancellationToken cancellationToken)
    {
        var book = _mapper.Map<Book>(_bookRepository.GetById(request.Id, cancellationToken).Result);
        _bookRepository.Delete(book);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<DeleteBookResponse>(book);
    }
}
