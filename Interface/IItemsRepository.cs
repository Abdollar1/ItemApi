using firstApi.DTO;
using firstApi.Entities;
using System;
using System.Collections.Generic;

namespace firstApi.Interface
{
    public interface IItemsRpository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();

        void createItem(Item item);

        void updateItem(Item item);

        void deleteItem(Guid id);
    }
}