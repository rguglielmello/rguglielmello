using Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Entities;

public class CatalogBrand : BaseEntity, IAggregateRoot
{
    public string Brand { get; private set; }
    public CatalogBrand(string brand)
    {
        Brand = brand;
    }
}
