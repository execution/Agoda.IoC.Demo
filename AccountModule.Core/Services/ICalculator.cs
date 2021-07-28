using Agoda.IoC.Core;

namespace AccountModule.Core.Services
{
    public interface ICalculatorAdd
    {
        int Add(int first, int second);
    }
    public interface ICalculatorSub
    {
        int Sub(int first, int second);
    }

    [RegisterSingleton(For = typeof(ICalculatorAdd))]
    [RegisterSingleton(For = typeof(ICalculatorSub))]
    public class Calculator : ICalculatorAdd, ICalculatorSub
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Sub(int first, int second)
        {
            return first - second;

        }
    }
}
