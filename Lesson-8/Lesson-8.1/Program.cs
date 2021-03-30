using System;
using System.Collections.Generic;

namespace Lesson_8._1
{
    class Program
    {
        static void BucketSort(ref int[] array)
        {
            //Предварительная проверка
            if (array == null || array.Length < 2)
            {
                return;
            }

            //min/max
            int min = array[0];
            int max = array[0];
            //Определение min/max элемента в массиве
            for (int i = 0; i < array.Length; i++)
            {
                //min
                if (array[i] < min)
                {
                    min = array[i];
                }
                //max
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            //Создается блок длинной в размер буфера
            var bucket = new List<int>[max - min + 1];

            //Инициализация блоков
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            //Заносим значения в блоки
            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i] - min].Add(array[i]);
            }
            //Собираем блоки
            int pos = 0;
            //Перебираем все элементы в массиве блоков
            for (int i = 0; i < bucket.Length; i++)
            {
                //Число элементов в блоках
                if (bucket[i].Count > 0)
                {
                    //Проходим по вложенностям (повторяющиеся значения)
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        //Выдаются обратно в массив (по ссылке) упорядоченные элементы 
                        array[pos] = bucket[i][j];
                        pos++;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //Задание 1
            var enterArray = new int[] { 13, 1, 34, 118, 92, 6,  8, 777, 888, 666, 555, 222, 1112, 1111, 53, 0, 1, 78, 99, 32, 6, 3, 4, 8, 8, 9, 16218, 31, 323, 0, 123 };

            Console.WriteLine("Массив до сортировки");
            for (int i = 0; i < enterArray.Length; i++)
            {
                Console.WriteLine($"{enterArray[i]}");
            }
            //ТЕСТ1
            var test = new TestClass[5];
            test[0] = new TestClass()
            { 
                InputA = 777,
                ExpectedValue = 777,
            };
            test[1] = new TestClass()
            {
                InputA = 888,
                ExpectedValue = 888,
            };
            test[2] = new TestClass()
            {
                InputA = 666,
                ExpectedValue = 666,
            };
            test[3] = new TestClass()
            {
                InputA = 555,
                ExpectedValue = 555,
            };
            test[4] = new TestClass()
            {
                InputA = 222,
                ExpectedValue = 222,
            };

            BucketSort(ref enterArray);

            Console.WriteLine();
            Console.WriteLine("BuckedSort");
            for (int i = 0; i < enterArray.Length; i++)
            {
                Console.WriteLine($"{enterArray[i]}");
            }

            Console.ReadKey();
        }
    }
}
