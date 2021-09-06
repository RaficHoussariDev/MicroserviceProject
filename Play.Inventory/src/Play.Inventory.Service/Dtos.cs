using System;

namespace Play.Inventory.Service
{
    public class Dtos
    {
        public record GrantItemsDto(Guid UserId, Guid CatalogItemId, int Quantity);

        public record InventoryItemDto(Guid CatalogItemId, string Name, string Description, int Quantity, DateTimeOffset AcquiredDate);
        public record CatalogItemDto(Guid id, string Name, string Description);
    }
}