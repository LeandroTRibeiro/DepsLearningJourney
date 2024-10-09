```

BenchmarkDotNet v0.14.0, Linux Mint 22 (Wilma)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.425
  [Host]     : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2


```
| Method                      | Mean     | Error    | StdDev   |
|---------------------------- |---------:|---------:|---------:|
| BenchmarkFindLargestNumber  | 27.68 ns | 0.268 ns | 0.224 ns |
| BenchmarkFindLargestNumber2 | 16.44 ns | 0.135 ns | 0.120 ns |
