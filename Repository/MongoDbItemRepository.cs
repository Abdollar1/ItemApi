using firstApi.Entities;
using firstApi.Interface;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace firstApi.Repository
{
    public class MongoDbItemRepository : IItemsRpository
    {

        private const string databaseName = "firstApi";
        private const string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection;


        public MongoDbItemRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName);

        }
            public void createItem(Item item)
        {
            itemsCollection.InsertOne(item);
        }

        public void deleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
         return itemsCollection.Find(new BsonDocument()).ToList();
            
        }

        public void updateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
