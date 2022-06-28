﻿using MediatR;
using Microsoft.bigPotatoWeb.Web.ViewModels;

namespace Microsoft.bigPotatoWeb.Web.Features.OrderDetails;

public class GetOrderDetails : IRequest<OrderViewModel>
{
    public string UserName { get; set; }
    public int OrderId { get; set; }

    public GetOrderDetails(string userName, int orderId)
    {
        UserName = userName;
        OrderId = orderId;
    }
}
