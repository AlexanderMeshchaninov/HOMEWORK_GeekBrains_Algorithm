using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант второй
            //БЕНЧМАРК
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
