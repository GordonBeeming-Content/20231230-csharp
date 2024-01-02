``` ini

BenchmarkDotNet=v0.13.1, OS=macOS 14.2.1 (23C71) [Darwin 23.2.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK=8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT
  DefaultJob : .NET 8.0.0 (8.0.23.53103), Arm64 RyuJIT


```
|            Method |       Mean |     Error |    StdDev |    Gen 0 |   Gen 1 |  Gen 2 | Allocated |
|------------------ |-----------:|----------:|----------:|---------:|--------:|-------:|----------:|
|  StringConcatTest | 141.177 μs | 2.7180 μs | 2.5424 μs | 339.5996 | 19.7754 | 3.9063 |  2,774 KB |
| StringBuilderTest |   5.995 μs | 0.0277 μs | 0.0259 μs |   4.4250 |  0.2823 |      - |     36 KB |
