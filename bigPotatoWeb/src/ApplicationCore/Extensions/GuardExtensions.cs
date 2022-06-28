using System.Collections.Generic;
using System.Linq;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities.BasketAggregate;
using Microsoft.bigPotatoWeb.ApplicationCore.Exceptions;

namespace Ardalis.GuardClauses;

public static class BasketGuards
{
    public static void NullBasket(this IGuardClause guardClause, int basketId, Basket basket)
    {
        if (basket == null)
            throw new BasketNotFoundException(basketId);
    }

    public static void EmptyBasketOnCheckout(this IGuardClause guardClause, IReadOnlyCollection<BasketItem> basketItems)
    {
        if (!basketItems.Any())
            throw new EmptyBasketOnCheckoutException();
    }
}
