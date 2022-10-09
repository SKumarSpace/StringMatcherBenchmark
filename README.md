# StringMatcherBenchmark

BenchmarkDotNet=v0.13.2

OS=Windows 11 (10.0.22621.521)

AMD Ryzen Threadripper 3960X, 1 CPU, 48 logical and 24 physical cores

.NET SDK=6.0.401

|    Method |      Mean |    Error |   StdDev |
|---------- |----------:|---------:|---------:|
|  MatchReg | 103.24 ns | 0.355 ns | 0.315 ns |
| MatchFile |  70.36 ns | 0.419 ns | 0.392 ns |
