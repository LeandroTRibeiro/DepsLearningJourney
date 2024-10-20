```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.418
  [Host]     : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2


```
| Method                 | Mean     | Error    | StdDev   | Median   |
|----------------------- |---------:|---------:|---------:|---------:|
| BenchmarkSingleNumber  | 599.5 ns | 12.05 ns | 14.80 ns | 600.8 ns |
| BenckmarkSingleNumber2 | 171.0 ns |  3.71 ns | 10.60 ns | 167.5 ns |
