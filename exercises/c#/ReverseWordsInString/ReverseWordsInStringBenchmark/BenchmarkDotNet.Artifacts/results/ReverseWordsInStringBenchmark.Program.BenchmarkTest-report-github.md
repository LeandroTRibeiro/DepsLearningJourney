```

BenchmarkDotNet v0.14.0, Linux Mint 22 (Wilma)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.425
  [Host]     : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2


```
| Method                         | Mean     | Error    | StdDev   |
|------------------------------- |---------:|---------:|---------:|
| BenchmarkReverseWordsInString  | 421.5 ns |  4.92 ns |  4.36 ns |
| BenchmarkReverseWordsInString2 | 808.8 ns | 15.75 ns | 14.73 ns |
