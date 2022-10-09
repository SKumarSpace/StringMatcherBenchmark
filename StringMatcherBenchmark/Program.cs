// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using StringMatcherBenchmark;

Console.WriteLine("Hello, World!");

//var x = new MyBenchmarks();
//Console.WriteLine(x.MatchReg());
//Console.WriteLine(x.MatchFile());

var summary = BenchmarkRunner.Run(typeof(Program).Assembly);