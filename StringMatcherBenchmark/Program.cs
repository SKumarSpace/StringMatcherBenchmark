using BenchmarkDotNet.Running;
using StringMatcherBenchmark;

//var x = new MyBenchmarks();
//Console.WriteLine(x.MatchReg());
//Console.WriteLine(x.MatchFile());
//Console.WriteLine(x.MatchFile());

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);