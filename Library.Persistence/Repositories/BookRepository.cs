using Library.Application.Repositories;
using Library.Domain.Entities;
using Library.Persistence.Context;

using Microsoft.EntityFrameworkCore;

namespace Library.Persistence.Repositories;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    public BookRepository(DataContext context) : base(context) { }

    public Task<Book> GetById(Guid id, CancellationToken cancellationToken)
    {
        return Context.Books.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
