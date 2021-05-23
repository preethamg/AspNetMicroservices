using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.DataAccess
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
