using System;

namespace Lesson_1._2
{
    class Program
    {
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;                                            //O(C)
            for (int i = 0; i < inputArray.Length; i++)             //O(N)
            {
                for (int j = 0; j < inputArray.Length; j++)         //O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++)     //O(N)
                    {
                        int y = 0;                                  //O(C)

                        if (j != 0)                                 //O(1)
                        {
                            y = k / j;  
                        }

                        sum += inputArray[i] + i + k + j + y;       //O(1)
                    }
                }
            }
            return sum;                                             //O(1)
        }
        static void Main(string[] args)
        {
            //Задача 2:
            //Итог: Асимптотическая сложность данного алгоритма: O(N*N*N) = O(N3)
        }
    }
}
