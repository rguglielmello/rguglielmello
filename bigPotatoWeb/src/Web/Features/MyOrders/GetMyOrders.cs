using MediatR;
using Microsoft.bigPotatoWeb.Web.ViewModels;

namespace Microsoft.bigPotatoWeb.Web.Features.MyOrders;

public class GetMyOrders : IRequest<IEnumerable<OrderViewModel>>
{
    public string UserName { get; set; }

    public GetMyOrders(string userName)
    {
        UserName = userName;
    }
}
