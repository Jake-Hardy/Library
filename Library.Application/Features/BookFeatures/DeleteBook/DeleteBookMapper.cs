using AutoMapper;
using Library.Domain.Entities;

namespace Library.Application.Features.BookFeatures.DeleteBook;

public sealed class DeleteBookMapper : Profile
{
    public DeleteBookMapper()
    {
        CreateMap<DeleteBookRequest, Book>();
        CreateMap<Book, DeleteBookResponse>();
    }
}
