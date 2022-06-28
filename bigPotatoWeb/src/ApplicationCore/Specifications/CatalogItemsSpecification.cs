using System;
using System.Linq;
using Ardalis.Specification;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Specifications;

public class CatalogItemsSpecification : Specification<CatalogItem>
{
    public CatalogItemsSpecification(params int[] ids)
    {
        Query.Where(c => ids.Contains(c.Id));
    }
}
