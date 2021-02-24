using System;
using Lesson_2._1;

namespace Lesson_2._2
{
    class Program
    {   
        /// <summary>
        /// Метод двоичного поиска возвращающий индекс искомого значения (не само значение)
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] inputArray, int searchValue) //O(N)
        {
            //Отсортировываем массив с помощью класса Array
            Array.Sort(inputArray);                                       //Сложно оценить асипмтотическую сложность данного метода, т.к. это стандартный метод класса
                                                                          //Array библиотеки .NET, инф. не нашел. Предположительно O(N).
            //Определяем границы массива
            int min = 0;
            int max = inputArray.Length - 1;

            //Выполняется пока не сошлись границы массива
            while (min <= max)                                            //O(logN)
            {
                //Определяется середина массива
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1; //Сужаем поиск с правой стороны
                }
                else
                {
                    min = min + 1; //Сужаем поиск с левой стороны
                }
            }
            return -1; //Если искомого значения нет, возвращаем -1, фактически ничего, поскольку -1 индекса массива не бывает
        }

        //Результат асимптотической сложности данного алгоритма составит: O(logN+N) = O (log N);

        static void Main(string[] args)
        {
            //Задача 2:
            int[] myArray = new int [] 
            { 
                9, 8, 7, 5, 6, 3, 4, 1, 2, 
                11, 13, 12, 15, 14, 17, 16, 
                19, 20, 18, 10, 2236, 434, 
                75, 98, -1, 213, 423, 765, 
                33, 1, 42, 09, -213, 43, 
            };

            //Тестируем метод BinarySearch
            var test = new TestClass[5];
            test[0] = new TestClass()
            {
                InputA = 8,             //Вносим: 8 - Ожидаем: 10
                ExpectedValue = 10,
            };
            test[1] = new TestClass()
            {
                InputA = 2236,          //Вносим: 2236 - Ожидаем: 33
                ExpectedValue = 33,
            };
            test[2] = new TestClass()
            {
                InputA = 75,            //Вносим: 75 - Ожидаем: 27
                ExpectedValue = 27,
            };
            test[3] = new TestClass()
            {
                InputA = -1,            //Вносим: -1 - Ожидаем: 1
                ExpectedValue = 1,
            };
            test[4] = new TestClass()
            {
                InputA = 999999,        //Вносим: 999999 - Ожидаем: Искомое значение не найдено
                ExpectedValue = -1,
            };
            Array.Sort(myArray);
            Console.WriteLine("Отсортированный массив");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"index - [{i}]\tvalue - [{myArray[i]}]");
            }
            Console.WriteLine("TECT");
            for (int i = 0; i < test.Length; i++)
            {
                int indexOfSearchElement = BinarySearch(myArray, test[i].InputA);

                if (indexOfSearchElement == -1)
                {
                    Console.WriteLine($"Ввели значение: {test[i].InputA}\t\t\tИскомое значение не найдено");
                }
                else
                {
                    Console.WriteLine($"Ввели значение: {test[i].InputA}\t\t\tИндекс искомого элемента (в отсортированном массиве): {indexOfSearchElement}");
                }
            }
            
            Console.ReadKey();
        }
    }
}
