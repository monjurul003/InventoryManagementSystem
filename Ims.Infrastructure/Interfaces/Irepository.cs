using System.Collections.Generic;
using Ims.Infrastructure.Model;

namespace Ims.Infrastructure.Interfaces
{
    public interface Irepository<T> where T : BaseEntity
    {
        void Add(T item);
        void Remove(int id);
        void Update(T item);
        T FindBy(int id);
        IEnumerable<T> FindAll();
    }
}