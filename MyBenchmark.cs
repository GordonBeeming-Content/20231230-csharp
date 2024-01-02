using System.Text;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class MyBenchmark
{
    [Benchmark]
    public string StringConcatTest()
    {
        var result = string.Empty;
        for(int i = 0; i < 1000; i++)
        {
            result += i.ToString();
        }
        return result;
    }

    [Benchmark]
    public string StringBuilderTest()
    {
        var result = new StringBuilder();
        for(int i = 0; i < 1000; i++)
        {
            result.Append(i.ToString());
        }
        return result.ToString();
    }
}
