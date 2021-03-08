using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson_4._1
{
    public class BenchmarkClass
    {
        //Поля
        private string[] _stringArray;
        private HashSet<string> _hashSet;
        private GenerateString _generateString;
        private Random _rnd;
        private int _numberOfItems = 10001;
        //Свойства
        private string RandomString { get; set; }
        private int Index { get; set; }
        
        //Конструктор класса
        public BenchmarkClass()
        {
            _hashSet = new HashSet<string>();
            _stringArray = new string[10001];
            
            _rnd = new Random(345);
            _generateString = new GenerateString();

            AddValues();
        }
        public void AddValues()
        {
            for (int i = 0; i < _numberOfItems; i++)
            {
                var str = _generateString.GenerateStrings(_rnd, 10);
                _stringArray[i] = str;
                _hashSet.Add(str);
            }
        }

        [Benchmark]
        public void TestOfStringArray()
        {
            Index = _rnd.Next(_numberOfItems);
            RandomString = _stringArray[Index];
            for (int i = 0; i < _numberOfItems; i++)
            {
                if (_stringArray[i] == RandomString)
                {
                    return;
                }
            }
        }

        [Benchmark]
        public void TestOfHashSet()
        {
            Index = _rnd.Next(_numberOfItems);
            RandomString = _stringArray[Index];
            for (int i = 0; i < _numberOfItems; i++)
            {
                if (_hashSet.Contains(RandomString))
                {
                    return;
                }
            }
        }
    }
}
