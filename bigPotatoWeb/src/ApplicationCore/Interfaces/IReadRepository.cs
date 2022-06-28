using Ardalis.Specification;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
