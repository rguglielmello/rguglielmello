using Ardalis.Specification;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Specifications;

public class CatalogItemNameSpecification : Specification<CatalogItem>
{
    public CatalogItemNameSpecification(string catalogItemName)
    {
        Query.Where(item => catalogItemName == item.Name);
    }
}
