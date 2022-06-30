using Microsoft.bigPotatoWeb.ApplicationCore.Entities;
using Microsoft.bigPotatoWeb.ApplicationCore.Interfaces;
using Microsoft.bigPotatoWeb.Web.Interfaces;
using Microsoft.bigPotatoWeb.Web.ViewModels;

namespace Microsoft.bigPotatoWeb.Web.Services;

public class CatalogItemViewModelService : ICatalogItemViewModelService
{
    private readonly IRepository<CatalogItem> _catalogItemRepository;

    public CatalogItemViewModelService(IRepository<CatalogItem> catalogItemRepository)
    {
        _catalogItemRepository = catalogItemRepository;
    }

    public async Task UpdateCatalogItem(CatalogItemViewModel viewModel)
    {
        var existingCatalogItem = await _catalogItemRepository.GetByIdAsync(viewModel.Id);
        existingCatalogItem.UpdateDetails(viewModel.Name, existingCatalogItem.Description, viewModel.Price, viewModel.ETA);
        await _catalogItemRepository.UpdateAsync(existingCatalogItem);
    }
}
