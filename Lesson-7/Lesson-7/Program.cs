using System;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ТЕСТ1
            var test1 = new TestClass[6];

            test1[0] = new TestClass()
            {
                InputA = 7,
                InputB = 7,
                InputC = 1,
                ExpectedValueA = 7,
                ExpectedValueB = 7,
                ExpectedString = "с препятствием",
            };
            test1[1] = new TestClass()
            {
                InputA = 7,
                InputB = 7,
                InputC = 0,
                ExpectedValueA = 7,
                ExpectedValueB = 7,
                ExpectedString = "без препятствия",
        };
            test1[2] = new TestClass()
            {
                InputA = 5,
                InputB = 7,
                InputC = 1,
                ExpectedValueA = 5,
                ExpectedValueB = 7,
                ExpectedString = "с препятствием",
            };
            test1[3] = new TestClass()
            {
                InputA = 5,
                InputB = 7,
                InputC = 0,
                ExpectedValueA = 5,
                ExpectedValueB = 7,
                ExpectedString = "без препятствия",
            };
            test1[4] = new TestClass()
            {
                InputA = 5,
                InputB = 8,
                InputC = 1,
                ExpectedValueA = 5,
                ExpectedValueB = 8,
                ExpectedString = "с препятствием",
            };
            test1[5] = new TestClass()
            {
                InputA = 5,
                InputB = 8,
                InputC = 0,
                ExpectedValueA = 5,
                ExpectedValueB = 8,
                ExpectedString = "без препятствия",
            };
            //Тестируем доску
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine($"Доска {test1[i].InputA} на {test1[i].InputB}\n[{test1[i].ExpectedString}]");
                Console.WriteLine();
                //Создаем экз класса Board
                var board = new Board(test1[i].InputA, test1[i].InputB);
                
                var map = board.InstallBoardWithBarrier(board, test1[i].InputC);

                board.PrintBoard(map);
                Console.WriteLine();
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
