using System.Collections.Generic;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities.OrderAggregate;
using Microsoft.bigPotatoWeb.UnitTests.Builders;
using Xunit;

namespace Microsoft.bigPotatoWeb.UnitTests.ApplicationCore.Entities.OrderTests;

public class OrderTotal
{
    private decimal _testUnitPrice = 42m;
    private int _testETA = 7;

    [Fact]
    public void IsZeroForNewOrder()
    {
        var order = new OrderBuilder().WithNoItems();

        Assert.Equal(0, order.Total());
    }

    [Fact]
    public void IsCorrectGiven1Item()
    {
        var builder = new OrderBuilder();
        var items = new List<OrderItem>
            {
                new OrderItem(builder.TestCatalogItemOrdered, _testUnitPrice, 1, _testETA)
            };
        var order = new OrderBuilder().WithItems(items);
        Assert.Equal(_testUnitPrice, order.Total());
    }

    [Fact]
    public void IsCorrectGiven3Items()
    {
        var builder = new OrderBuilder();
        var order = builder.WithDefaultValues();

        Assert.Equal(builder.TestUnitPrice * builder.TestUnits, order.Total(), order.TotalETA());
    }
}
