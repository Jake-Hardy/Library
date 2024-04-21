using Library.Application.Repositories;
using Library.Domain.Common;
using Library.Persistence.Context;

using Microsoft.EntityFrameworkCore;

namespace Library.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly DataContext Context;

    public BaseRepository(DataContext context)
    {
        Context = context;
    }

    public void Create(T entity)
    {
        entity.DateCreated = DateTimeOffset.UtcNow;
        Context.Add(entity);
    }

    public void Update(T entity) 
    {
        entity.DateUpdated = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public void Delete(T entity) 
    {
        entity.DateDeleted = DateTimeOffset.UtcNow;
        entity.DateUpdated = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public Task<T> Get(Guid id, CancellationToken cancellationToken)
    {
        return Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<List<T>> GetAll(CancellationToken cancellationToken)
    {
        return Context.Set<T>().Where(x => x.DateDeleted == null).ToListAsync(cancellationToken);
    }
}
