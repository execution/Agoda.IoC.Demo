using System;
using System.Threading.Tasks;

namespace Common
{
    public interface IToolSet<T>
    {
        Task<TResult> MeasureExecutionTimeAsync<TResult>(Func<Task<TResult>> func);
    }
}
