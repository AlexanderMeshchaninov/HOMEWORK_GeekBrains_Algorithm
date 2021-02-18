using System;
using Lesson_1._1;

namespace Lesson_1._3
{
    class Program
    {
        static long Fibonacci(int n)
        {
            //Вариант простой, но плохой, т.к. если ввести значение больше 60 уже потребуется "вечность" для ожидания результата

            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static long FibonacciWithCicle(int n)
        {
            //Вариант с циклом работает в разы быстрее

            long a = 0;
            long b = 1;
            long temp;
            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b += temp; 
            }

            return a;
        }

        //Массив (кэш) куда сбрасываются значения для последующей обработки
        static decimal[] cache = new decimal[150];
        static decimal FibonacciWithCache(int n)
        {
            if (cache[n] == 0)
            {
                if (n == 1 || n == 2)
                {
                    cache[n] = 1;
                }
                else
                {
                    cache[n] = FibonacciWithCache(n - 2) + FibonacciWithCache(n - 1);
                }
            }
            return cache[n];
        }
        static void Main(string[] args)
        {
            //Задача 3:
            //Вариант первый
            {
                var test = new TestClass[5];

                test[0] = new TestClass() //Введено: 12 - Ответ: 144
                {
                    InputN = 12,
                    ExpectedValue = 144,
                };
                test[1] = new TestClass() //Введено: 12 - Ответ: 5702887
                {
                    InputN = 34,
                    ExpectedValue = 5702887,
                };
                test[2] = new TestClass() //Введено: 8 - Ответ: 21
                {
                    InputN = 8,
                    ExpectedValue = 21,
                };
                test[3] = new TestClass() //Введено: 15 - Ответ: 610
                {
                    InputN = 15,
                    ExpectedValue = 610,
                };
                test[4] = new TestClass() //Введено: 26 - Ответ: 121393
                {
                    InputN = 26,
                    ExpectedValue = 121393,
                };

                for (int i = 0; i < test.Length; i++)
                {
                    var result1 = Fibonacci(test[i].InputN);
                    var result2 = FibonacciWithCicle(test[i].InputN);
                    Console.WriteLine($"Введено: {test[i].InputN} - Ответ: \nчисло Фибоначи с рекурсией: {result1}\nчисло Фибоначи с циклом: {result2}");
                }
                Console.ReadKey();
            }
            //Вариант второй
            //Реализация с неким "кэшем" для того, чтобы значения которые уже были посчитаны попадали в "кэш" и их не пришлось бы снова пересчитывать
            //Обрабатывает огромные значения на уровне с циклом через рекурсию
            {
                var test = new TestClass[6];

                test[0] = new TestClass() //Введено: 76 - Ответ: 3416454622906707
                {
                    InputN = 76,
                    ExpectedValue = 3416454622906707,
                };
                test[1] = new TestClass() //Введено: 56 - Ответ: 225851433717
                {
                    InputN = 56,
                    ExpectedValue = 225851433717,
                };
                test[2] = new TestClass() //Введено: 90 - Ответ: 2880067194370816120
                {
                    InputN = 90,
                    ExpectedValue = 2880067194370816120,
                };
                test[3] = new TestClass() //Введено: 105 - Ответ: 2111485077978050
                {
                    InputN = 75,
                    ExpectedValue = 2111485077978050, //в данном случае из-за размера значения указал M, чтобы не было ошибки
                };
                test[4] = new TestClass() //Введено: 94 - Ответ: 218922995834555169026
                {
                    InputN = 99,
                    ExpectedValue = 218922995834555169026M, //в данном случае из-за размера значения указал M, чтобы не было ошибки
                };
                test[5] = new TestClass() //Введено: 12 - Ответ: 144
                {
                    InputN = 12,
                    ExpectedValue = 144,
                };
                
                for (int i = 0; i < test.Length; i++)
                {
                    var result = FibonacciWithCache(test[i].InputN);

                    Console.WriteLine($"Введено: {test[i].InputN} - Ответ: число Фибоначи с кэшем: {result}");
                    
                }
                Console.ReadKey();
            }
        }
    }
}
