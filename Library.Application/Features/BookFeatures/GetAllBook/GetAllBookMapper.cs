using Library.Domain.Entities;

using AutoMapper;

namespace Library.Application.Features.BookFeatures.GetAllBook;

public sealed class GetAllBookMapper : Profile 
{
    public GetAllBookMapper()
    {
        CreateMap<Book, GetAllBookResponse>();
    }
}
