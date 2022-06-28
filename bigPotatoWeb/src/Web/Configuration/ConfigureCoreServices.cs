using Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;
using Microsoft.bigPotatoWeb.ApplicationCore.Services;
using Microsoft.bigPotatoWeb.Infrastructure.Data;
using Microsoft.bigPotatoWeb.Infrastructure.Data.Queries;
using Microsoft.bigPotatoWeb.Infrastructure.Logging;
using Microsoft.bigPotatoWeb.Infrastructure.Services;

namespace Microsoft.bigPotatoWeb.Web.Configuration;

public static class ConfigureCoreServices
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
        services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));

        services.AddScoped<IBasketService, BasketService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IBasketQueryService, BasketQueryService>();
        services.AddSingleton<IUriComposer>(new UriComposer(configuration.Get<CatalogSettings>()));
        services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
        services.AddTransient<IEmailSender, EmailSender>();

        return services;
    }
}
