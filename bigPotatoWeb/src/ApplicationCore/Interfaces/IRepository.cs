using Ardalis.Specification;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
