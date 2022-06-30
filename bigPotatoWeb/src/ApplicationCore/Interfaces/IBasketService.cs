using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities.BasketAggregate;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

public interface IBasketService
{
    Task TransferBasketAsync(string anonymousId, string userName);
    Task<Basket> AddItemToBasket(string username, int catalogItemId, decimal price, int quantity = 1, int eta = 6);
    Task<Basket> SetQuantities(int basketId, Dictionary<string, int> quantities);
    Task DeleteBasketAsync(int basketId);
}
