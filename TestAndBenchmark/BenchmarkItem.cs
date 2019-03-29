using BenchmarkDotNet.Attributes;
using ChainingAssertion;
using Xunit;

namespace TestAndBenchmark
{
    public class BenchmarkItem
    {
        [Fact]
        [Benchmark]
        public void Bench01()
        {
            "abcde".Is("abcde");
        }

        [Fact]
        [Benchmark]
        public void Bench02()
        {
            1234.Is(5678);
        }
    }
}
