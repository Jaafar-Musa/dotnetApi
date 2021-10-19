using System;
using System.Collections.Generic;
using Api.Entities;

namespace Api.Repositories
{
    public interface IInMemItemsRepo
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}