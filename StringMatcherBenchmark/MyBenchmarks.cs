using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringMatcherBenchmark
{
    public class MyBenchmarks
    {
        private const string inputString = "1G1ZG57B&9";
        private const string outputString = "1G1ZG57B29";

        [Benchmark]
        public bool MatchReg()
        {
            return Regex.IsMatch(outputString, @"1G1ZG57B.9");
        }

        [Benchmark]
        public bool MatchFile()
        {
            return FileSystemName.MatchesSimpleExpression("1G1ZG57B?9", outputString);
        }

        [Benchmark]
        public bool MatchOriginal()
        {
            return inputString[..8] == outputString[..8] && outputString[^1..] == inputString[^1..];
        }
    }
}