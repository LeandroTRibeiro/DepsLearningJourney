```

BenchmarkDotNet v0.14.0, Linux Mint 22 (Wilma)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.401
  [Host]     : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2


```
| Method                | Mean     | Error    | StdDev   |
|---------------------- |---------:|---------:|---------:|
| BenchmarkUsingLinq    | 74.40 ns | 1.035 ns | 0.918 ns |
| BenchmarkUsingInPlace | 49.10 ns | 0.999 ns | 1.111 ns |
