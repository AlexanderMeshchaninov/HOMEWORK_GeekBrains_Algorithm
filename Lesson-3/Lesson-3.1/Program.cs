using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант первый
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }   
    }
}
