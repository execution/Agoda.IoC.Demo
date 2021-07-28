using AccountModule.Core.Entities;
using Agoda.IoC.Core;
using Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountModule.Core.Repositories
{
    [RegisterPerRequest(For = typeof(IGenericRepo<AccountEntity>))]
    public class AccountRepository : IGenericRepo<AccountEntity>
    {
        private readonly IToolSet<AccountEntity> _toolSet;
        public AccountRepository(IToolSet<AccountEntity> toolSet)
        {
            _toolSet = toolSet;
        }
        public async Task<List<AccountEntity>> GetAll()
        {
            return await _toolSet.MeasureExecutionTimeAsync(async () =>
            {
                var accountList = new List<AccountEntity>();
                for (int i = 1; i <= 20; i++)
                {
                    await Task.Delay(1);
                    accountList.Add(new(Guid.NewGuid(), $"Account Name {i}", $"Account Surname{i}"));
                }
                return accountList;
            });
        }
    }
}
