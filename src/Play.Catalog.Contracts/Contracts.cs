using System;

namespace Play.Catalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Descrption);

    public record CatalogItemUpdated(Guid ItemId, string Name, string Descrption);

    public record CatalogItemDeleted(Guid ItemId);
}