using System.Threading.Tasks;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

public interface ITokenClaimsService
{
    Task<string> GetTokenAsync(string userName);
}
