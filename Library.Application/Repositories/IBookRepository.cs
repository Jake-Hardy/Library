using Library.Domain.Entities;

namespace Library.Application.Repositories;

public interface IBookRepository : IBaseRepository<Book>
{
    Task<Book> GetById(Guid id, CancellationToken cancellationToken);
}
