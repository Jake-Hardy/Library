using AutoMapper;
using Library.Domain.Entities;

namespace Library.Application.Features.BookFeatures.CreateBook;

public sealed class CreateBookMapper : Profile 
{
    public CreateBookMapper()
    {
        CreateMap<CreateBookRequest, Book>();
        CreateMap<Book, CreateBookResponse>();
    }
}
