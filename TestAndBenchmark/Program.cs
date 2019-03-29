using BenchmarkDotNet.Running;

namespace TestAndBenchmark
{
    internal class Program
    {
        private static void Main()
        {
            BenchmarkRunner.Run<BenchmarkItem>();
        }
    }
}
