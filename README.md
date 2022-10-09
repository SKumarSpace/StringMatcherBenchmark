# StringMatcherBenchmark

BenchmarkDotNet=v0.13.2

OS=Windows 11 (10.0.22621.521)

AMD Ryzen Threadripper 3960X, 1 CPU, 48 logical and 24 physical cores

.NET SDK=6.0.401

|        Method |      Mean |    Error |   StdDev |
|-------------- |----------:|---------:|---------:|
|      MatchReg | 101.60 ns | 1.146 ns | 1.072 ns |
|     MatchFile |  73.20 ns | 0.602 ns | 0.564 ns |
| MatchOriginal |  35.05 ns | 0.721 ns | 0.675 ns |
