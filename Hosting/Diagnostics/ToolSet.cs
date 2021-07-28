using Common;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Agoda.IoC.Core;
using AccountModule.Core.Entities;
using ContactModule.Core.Entities;
using PropertyModule.Core.Entities;

namespace Hosting.Diagnostics
{
    [RegisterPerRequest(For = typeof(IToolSet<>), GenericArgument = typeof(AccountEntity))]
    [RegisterPerRequest(For = typeof(IToolSet<>), GenericArgument = typeof(ContactEntity))]
    [RegisterPerRequest(For = typeof(IToolSet<>), GenericArgument = typeof(PropertyEntity))]
    public class ToolSet<T> : IToolSet<T>
    {
        private readonly ILogger<T> _logger;

        public ToolSet(ILogger<T> logger) => _logger = logger;

        public async Task<TResult> MeasureExecutionTimeAsync<TResult>(Func<Task<TResult>> func)
        {
            var stopwatch = Stopwatch.StartNew();
            try
            {
                return await func();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                var elapsed = stopwatch.ElapsedMilliseconds;
                _logger.LogInformation($"< !-- {this} { elapsed} ms-- > ");
            }
        }
    }
}
