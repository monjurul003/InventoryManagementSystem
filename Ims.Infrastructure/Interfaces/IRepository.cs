using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Ims.Infrastructure.Model;

namespace Ims.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<bool> Insert(T item, DbConnection connection);
        Task<bool> Remove(int id, DbConnection connection);
        Task<bool> Update(T item, DbConnection connection);
        Task<T> FindById(int id, DbConnection connection);
        Task<T> FindByName(string name, DbConnection connection);
        Task<IEnumerable<Product>> FindAll(DbConnection connection);
    }
}