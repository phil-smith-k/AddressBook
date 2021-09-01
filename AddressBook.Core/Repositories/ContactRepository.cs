using AddressBook.Core.Contracts;
using AddressBook.Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AddressBook.Core.Repositories
{
    public class ContactRepository : IRepository<Contact>
    {
        private readonly SemaphoreSlim fileWriterSemaphore = new SemaphoreSlim(1);

        public async Task<Contact> Create(Contact entity)
        {
            var json = JsonConvert.SerializeObject(entity);

            await fileWriterSemaphore.WaitAsync().ConfigureAwait(false);
            try
            {
                using var file = File.Open(@"C:\EFA\AddressBook\AddressBook.UI\Contacts.txt", FileMode.Append);
                using var streamWriter = new StreamWriter(file);

                await streamWriter.WriteLineAsync(json).ConfigureAwait(false);
                await streamWriter.FlushAsync().ConfigureAwait(false);
            }
            catch
            {
                return default;
            }
            finally
            {
                fileWriterSemaphore.Release();
            }

            return entity;
        }

        public Task<Contact> Read(string id)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<Contact> ReadMany(int skip = 0, int take = 0)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact updatedEntity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}

