using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.bigPotatoWeb.Web.ViewModels;

namespace Microsoft.bigPotatoWeb.Web.Services;

public interface ICatalogViewModelService
{
    Task<CatalogIndexViewModel> GetCatalogItems(int pageIndex, int itemsPage, int? brandId, int? typeId);
    Task<IEnumerable<SelectListItem>> GetBrands();
    Task<IEnumerable<SelectListItem>> GetTypes();
}
