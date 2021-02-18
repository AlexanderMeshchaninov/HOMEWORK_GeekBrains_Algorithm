using System;

namespace Lesson_1._1
{
    class Program
    {
        static string CheckNumber(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }

                i++;
            }
            if (d == 0)
            {
                return "Простое";
            }
            else
            {
                return "Не простое";
            }
        }
        static string CheckNumberModified(int n)
        {
            if (n < 0 || n == 0)
            {
                return "Ошибка. Вы ввели 0 или отрицательное число!";
            }

            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }

                i++;
            }
            if (d == 0)
            {
                return "Простое";
            }
            else
            {
                return "Не простое";
            }
        }

        static void Main(string[] args)
        {
            //Задача 1
            //Вариант первый
            {
                var test = new TestClass[6];

                test[0] = new TestClass() //Ввод 25 - Ответ: Не простое
                {
                    InputN = 25,
                    ExpectedValueString = "Не простое",
                };
                test[1] = new TestClass() //Ввод 44 - Ответ: Не простое
                {
                    InputN = 44,
                    ExpectedValueString = "Не простое",
                };
                test[2] = new TestClass() //Ввод 253 - Ответ: Не простое
                {
                    InputN = 253,
                    ExpectedValueString = "Не простое",
                };
                test[3] = new TestClass() //Ввод 898646 - Ответ: Не простое
                {
                    InputN = 898646,
                    ExpectedValueString = "Не простое",
                };
                test[4] = new TestClass() //Ввод 1 - Ответ: Простое
                {
                    InputN = 1,
                    ExpectedValueString = "Простое",
                };
                test[5] = new TestClass() //Ввод 2 - Ответ: Простое
                {
                    InputN = 2,
                    ExpectedValueString = "Простое",
                };

                for (int i = 0; i < test.Length; i++)
                {
                    var result = CheckNumber(test[i].InputN);

                    Console.WriteLine($"Ввод числа: {test[i].InputN} - Ответ: {result}");
                }
                Console.ReadKey();
            }

            //Вариант второй
            //Если ввести 0 или отрицательное число - Ответ: Ошибка. Вы ввели 0 или отрицательное число!
            {
                var test1 = new TestClass[5];

                test1[0] = new TestClass() //Ввод -25 - Ответ: Ошибка. Вы ввели 0 или отрицательное число!
                {
                    InputN = -25,
                    ExpectedValueString = "Ошибка. Вы ввели 0 или отрицательное число!",
                };
                test1[1] = new TestClass() //Ввод -15 - Ответ: Ошибка. Вы ввели 0 или отрицательное число!
                {
                    InputN = -15,
                    ExpectedValueString = "Ошибка. Вы ввели 0 или отрицательное число!",
                };
                test1[2] = new TestClass() //Ввод -253 - Ответ: Ошибка. Вы ввели 0 или отрицательное число!
                {
                    InputN = -253,
                    ExpectedValueString = "Ошибка. Вы ввели 0 или отрицательное число!",
                };
                test1[3] = new TestClass() //Ввод 0 - Ответ: Ошибка. Вы ввели 0 или отрицательное число!
                {
                    InputN = 0,
                    ExpectedValueString = "Ошибка. Вы ввели 0 или отрицательное число!",
                };
                test1[4] = new TestClass() //Ввод 2 - Ответ: Простое
                {
                    InputN = 2,
                    ExpectedValueString = "Простое",
                };

                for (int i = 0; i < test1.Length; i++)
                {
                    var result = CheckNumberModified(test1[i].InputN);

                    Console.WriteLine($"Ввод числа: {test1[i].InputN} - Ответ: {result}");
                }
                Console.ReadKey();
            }
        }
    }
}
