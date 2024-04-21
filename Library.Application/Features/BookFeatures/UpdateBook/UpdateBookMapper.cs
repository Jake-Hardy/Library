using AutoMapper;
using Library.Domain.Entities;

namespace Library.Application.Features.BookFeatures.UpdateBook;

public sealed class UpdateBookMapper : Profile
{
    public UpdateBookMapper()
    {
        CreateMap<UpdateBookRequest, Book>();
        CreateMap<Book, UpdateBookResponse>();
    }
}
