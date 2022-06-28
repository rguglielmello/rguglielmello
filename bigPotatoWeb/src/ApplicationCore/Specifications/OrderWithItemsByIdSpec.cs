using Ardalis.Specification;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Specifications;

public class OrderWithItemsByIdSpec : Specification<Order>, ISingleResultSpecification
{
    public OrderWithItemsByIdSpec(int orderId)
    {
        Query
            .Where(order => order.Id == orderId)
            .Include(o => o.OrderItems)
            .ThenInclude(i => i.ItemOrdered);
    }
}
