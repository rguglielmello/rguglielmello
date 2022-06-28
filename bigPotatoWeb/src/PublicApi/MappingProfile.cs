using AutoMapper;
using Microsoft.bigPotatoWeb.ApplicationCore.Entities;
using Microsoft.bigPotatoWeb.PublicApi.CatalogBrandEndpoints;
using Microsoft.bigPotatoWeb.PublicApi.CatalogItemEndpoints;
using Microsoft.bigPotatoWeb.PublicApi.CatalogTypeEndpoints;

namespace Microsoft.bigPotatoWeb.PublicApi;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CatalogItem, CatalogItemDto>();
        CreateMap<CatalogType, CatalogTypeDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Type));
        CreateMap<CatalogBrand, CatalogBrandDto>()
            .ForMember(dto => dto.Name, options => options.MapFrom(src => src.Brand));
    }
}
