using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson_3._2
{
    public class PointClass
    {
        //Для типа float
        public float X;
        public float Y;
        //Для типа Double
        public double Xd;
        public double Yd;
    }
    public struct PointStruct
    {
        //Для типа float
        public float X;
        public float Y;
        //Для типа double
        public double Xd;
        public double Yd;
    }
    public class BenchmarkClass
    {
        //Решил протестировать все методы (в том числе с квадратным корнем), кроме того, значения присваиваются через класс Random
        private Random rnd = new Random(245);
        
        //(Ссылочный тип) - float без квадратного корня
        public float PointDistanceShortFloat(PointClass pointOne, PointClass pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return (x * x) + (y * y);
            }
        [Benchmark]
        public void BenchmarkOfPointDistanceFloat()
        {
            for (int i = 0; i <= 1500; i++)
            {
                var pointOneFloat = new PointClass() { X = rnd.Next(200), Y = rnd.Next(200) };
                var pointTwoFloat = new PointClass() { X = rnd.Next(345), Y = rnd.Next(345) };

                PointDistanceShortFloat(pointOneFloat, pointTwoFloat);
            }
        }
        //(Ссылочный тип) - double с квадратным корнем
        public double PointDistanceDoubleWithSqrt(PointClass pointOne, PointClass pointTwo)
        {
            double xD = pointOne.Xd - pointTwo.Xd;
            double yD = pointOne.Yd - pointTwo.Yd;
            return Math.Sqrt((xD * xD) + (yD * yD));
        }
        [Benchmark]
        public void BenchmarkOfPointDistanceDoubleWithSqrt()
        {
            for (int i = 0; i <= 1500; i++)
            {
                var pointOneDouble = new PointClass() { Xd = rnd.Next(200), Yd = rnd.Next(200) };
                var pointTwoDouble = new PointClass() { Xd = rnd.Next(345), Yd = rnd.Next(345) };

                PointDistanceDoubleWithSqrt(pointOneDouble, pointTwoDouble);
            }
        }
        //(Значимый тип) - float без квадратного корня
        public float PointDistanceShortFloat(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x) + (y * y);
        }
        [Benchmark]
        public void BenchmarkOfPointDistanceShortFloat()
        {
            for (int i = 0; i <= 1500; i++)
            {
                var pointOneStrFloat = new PointStruct() { X = rnd.Next(200), Y = rnd.Next(200) };
                var pointTwoStrFloat = new PointStruct() { X = rnd.Next(345), Y = rnd.Next(345) };

                PointDistanceShortFloat(pointOneStrFloat, pointTwoStrFloat);
            }
        }
        //(Значимый тип) - double с квадратный корнем
        public double PointDistanceShortDoubleWithSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            double xD = pointOne.Xd - pointTwo.Xd;
            double yD = pointOne.Yd - pointTwo.Yd;
            return Math.Sqrt((xD * xD) + (yD * yD));
        }
        [Benchmark]
        public void BenchmarkOfPointDistanceShortDoubleWithSqrt()
        {
            for (int i = 0; i <= 1500; i++)
            {
                var pointOneStrDouble = new PointStruct() { Xd = rnd.Next(200), Yd = rnd.Next(200) };
                var pointTwoStrDouble = new PointStruct() { Xd = rnd.Next(345), Yd = rnd.Next(345) };

                PointDistanceShortDoubleWithSqrt(pointOneStrDouble, pointTwoStrDouble);
            }
        }
    }
}
