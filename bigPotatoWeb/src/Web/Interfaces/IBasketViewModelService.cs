using Microsoft.bigPotatoWeb.ApplicationCore.Entities.BasketAggregate;
using Microsoft.bigPotatoWeb.Web.Pages.Basket;

namespace Microsoft.bigPotatoWeb.Web.Interfaces;

public interface IBasketViewModelService
{
    Task<BasketViewModel> GetOrCreateBasketForUser(string userName);
    Task<int> CountTotalBasketItems(string username);
    Task<BasketViewModel> Map(Basket basket);
}
