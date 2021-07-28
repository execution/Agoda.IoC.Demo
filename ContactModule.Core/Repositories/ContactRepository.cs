using Agoda.IoC.Core;
using Common;
using ContactModule.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactModule.Core.Repositories
{
    [RegisterPerRequest(For = typeof(IGenericRepo<ContactEntity>))]
    public class ContactRepository : IGenericRepo<ContactEntity>
    {
        private readonly IToolSet<ContactEntity> _toolSet;
        public ContactRepository(IToolSet<ContactEntity> toolSet)
        {
            _toolSet = toolSet;
        }
        public async Task<List<ContactEntity>> GetAll()
        {
            return await _toolSet.MeasureExecutionTimeAsync(async () =>
            {
                var contacts = new List<ContactEntity>();
                for (int i = 1; i <= 20; i++)
                {
                    await Task.Delay(2);
                    contacts.Add(new(Guid.NewGuid(), $"Contact Name {i}", $"Contact Surname{i}", $"0990909{i:00}"));
                }
                return contacts;
            });
        }
    }
}
