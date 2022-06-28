using System.Threading.Tasks;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

public interface IOrderService
{
    Task CreateOrderAsync(int basketId, Address shippingAddress);
}
