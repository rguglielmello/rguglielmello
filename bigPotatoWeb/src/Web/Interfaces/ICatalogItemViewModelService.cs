using Microsoft.bigPotatoWeb.Web.ViewModels;

namespace Microsoft.bigPotatoWeb.Web.Interfaces;

public interface ICatalogItemViewModelService
{
    Task UpdateCatalogItem(CatalogItemViewModel viewModel);
}
