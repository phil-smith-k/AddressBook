using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Contracts
{
    public interface IRepository<T>
    {
        Task<T> Create(T entity);

        Task<T> Read(string id);

        IAsyncEnumerable<T> ReadMany(int skip = default, int take = 5);

        T Update(T updatedEntity);

        bool Delete(string id);
    }
}
