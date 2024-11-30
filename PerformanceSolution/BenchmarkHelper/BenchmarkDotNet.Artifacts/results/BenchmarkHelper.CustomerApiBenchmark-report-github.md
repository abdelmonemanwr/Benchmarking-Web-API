```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5073/22H2/2022Update)
Intel Core i5-2450M CPU 2.50GHz (Sandy Bridge), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX


```
| Method                                 | Mean     | Error     | StdDev   | Median   | Allocated |
|--------------------------------------- |---------:|----------:|---------:|---------:|----------:|
| TestStringConcatenationEndpoint        | 8.400 ms | 0.4459 ms | 1.272 ms | 7.884 ms |   2.86 KB |
| TestStringBuilderConcatenationEndpoint | 6.719 ms | 0.5526 ms | 1.585 ms | 6.277 ms |   2.83 KB |
