using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstApi.DTO;
using firstApi.Entities;
using firstApi.Interface;

namespace firstApi.Repository
{
    public class InMemItemsRepositorys
    {
        public class InMemItemsRepository : IItemsRpository
        {
            private readonly List<Item> items = new()
            {
                new Item { id = Guid.NewGuid(), name = "Asap", price = 90, createdDate = DateTime.Now },
                new Item { id = Guid.NewGuid(), name = "Osman", price = 100, createdDate = DateTime.Now },
                new Item { id = Guid.NewGuid(), name = "kofi", price = 90, createdDate = DateTime.Now },
                new Item { id = Guid.NewGuid(), name = "Marown", price = 90, createdDate = DateTime.Now },

            };

            public IEnumerable<Item> GetItems()
            {
                return items;
            }
 

         public Item GetItem(Guid id)
            {
                return items.Where(item => item.id == id).SingleOrDefault();
            }

            public void createItem(Item item)
            {
                items.Add(item);
            }

            public void updateItem(Item item)
            {
                var index = items.FindIndex(existingItem => existingItem.id == item.id);
                items[index] = item;
            }

            public void deleteItem(Guid id)
            {
               var index = items.FindIndex((item) => item.id == id);
                items.RemoveAt(index);
            }
        }



    }
}
