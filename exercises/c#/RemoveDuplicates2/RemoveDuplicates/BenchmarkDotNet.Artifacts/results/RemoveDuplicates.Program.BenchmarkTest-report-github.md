```

BenchmarkDotNet v0.14.0, Linux Mint 22 (Wilma)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.418
  [Host]     : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2


```
| Method            | Mean     | Error   | StdDev  |
|------------------ |---------:|--------:|--------:|
| TestHashSetMethod | 266.3 ns | 2.22 ns | 2.07 ns |
| TestListMethod    | 179.9 ns | 0.76 ns | 0.71 ns |
