using BenchmarkDotNet.Running;
using System;

namespace LINQBenchmarkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Student>();
        }
    }
}
