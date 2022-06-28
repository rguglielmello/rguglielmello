using Ardalis.Specification.EntityFrameworkCore;
using Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

namespace Microsoft.bigPotatoWeb.Infrastructure.Data;

public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(CatalogContext dbContext) : base(dbContext)
    {
    }
}
