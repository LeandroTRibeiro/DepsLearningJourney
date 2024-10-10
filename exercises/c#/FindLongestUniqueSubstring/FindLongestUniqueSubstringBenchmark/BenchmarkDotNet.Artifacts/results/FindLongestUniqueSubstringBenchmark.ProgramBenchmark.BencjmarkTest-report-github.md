```

BenchmarkDotNet v0.14.0, Linux Mint 22 (Wilma)
Intel Core i7-8565U CPU 1.80GHz (Whiskey Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 6.0.425
  [Host]     : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.33 (6.0.3324.36610), X64 RyuJIT AVX2


```
| Method                               | phrase  | Mean      | Error    | StdDev   | Median    |
|------------------------------------- |-------- |----------:|---------:|---------:|----------:|
| **BenchmarkFindLongestUniqueSubstring**  | **abc**     |  **69.29 ns** | **1.103 ns** | **1.032 ns** |  **68.91 ns** |
| BenchmarkFindLongestUniqueSubstring2 | abc     | 216.87 ns | 2.308 ns | 2.267 ns | 216.21 ns |
| **BenchmarkFindLongestUniqueSubstring**  | **abccba**  |  **75.62 ns** | **0.669 ns** | **0.593 ns** |  **75.53 ns** |
| BenchmarkFindLongestUniqueSubstring2 | abccba  | 227.16 ns | 2.450 ns | 2.172 ns | 227.06 ns |
| **BenchmarkFindLongestUniqueSubstring**  | **abcdefg** | **188.52 ns** | **1.381 ns** | **1.292 ns** | **188.50 ns** |
| BenchmarkFindLongestUniqueSubstring2 | abcdefg | 456.69 ns | 2.515 ns | 2.229 ns | 456.21 ns |
| **BenchmarkFindLongestUniqueSubstring**  | **bbbbb**   |  **18.70 ns** | **0.403 ns** | **0.943 ns** |  **18.23 ns** |
| BenchmarkFindLongestUniqueSubstring2 | bbbbb   | 138.57 ns | 2.786 ns | 3.422 ns | 137.16 ns |
| **BenchmarkFindLongestUniqueSubstring**  | **pwwkew**  |  **49.65 ns** | **0.478 ns** | **0.424 ns** |  **49.43 ns** |
| BenchmarkFindLongestUniqueSubstring2 | pwwkew  | 183.56 ns | 1.329 ns | 1.178 ns | 183.36 ns |
