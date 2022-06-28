[assembly: HostingStartup(typeof(Microsoft.bigPotatoWeb.Web.Areas.Identity.IdentityHostingStartup))]
namespace Microsoft.bigPotatoWeb.Web.Areas.Identity;

public class IdentityHostingStartup : IHostingStartup
{
    public void Configure(IWebHostBuilder builder)
    {
        builder.ConfigureServices((context, services) =>
        {
        });
    }
}
