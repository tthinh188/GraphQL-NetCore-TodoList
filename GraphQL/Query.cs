using System.Linq;
using HotChocolate;
using HotChocolate.Data;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemList> GetList([ScopedService] ApiDbContext context)
        {
            return context.Lists;
        }

        [UseDbContext(typeof(ApiDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ItemData> GetDatas([ScopedService] ApiDbContext context)
        {
            return context.Items;
        }
    }
}