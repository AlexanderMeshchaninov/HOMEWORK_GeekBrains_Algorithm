using System;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задача вторая

            //Console.WriteLine("ИЗНАЧАЛЬНАЯ КАРТА ДЕРЕВА");
            //var myTree = new Node();
            //myTree.AddItem(30);
            //myTree.AddItem(25);
            //myTree.AddItem(41);
            //myTree.AddItem(20);
            //myTree.AddItem(27);
            //myTree.AddItem(50);
            //myTree.AddItem(35);
            //myTree.AddItem(61);
            //myTree.PrintMethodThree(myTree);
            //Console.ReadKey();
            //Console.Clear();

            ////ТЕСТ - 1
            //Console.WriteLine("ТЕСТ-1 - Добавление элементов");
            //var test1 = new TestClass[5];
            //test1[0] = new TestClass()
            //{
            //    InputA = 40,
            //    ExpectedValue = 40,     //Ввод: 40 - Получаем: новый элемент со значение 40 добавился в дерево (является листом) [Left = null] [Right = null] [Parent = 35]
            //                            //Находится в правой части
            //};
            //test1[1] = new TestClass()
            //{
            //    InputA = 28,
            //    ExpectedValue = 28,     //Ввод: 28 - Получаем: новый элемент со значение 28 добавился в дерево (является листом) [Left = null] [Right = null] [Parent = 27]
            //                            //Находится в правой части
            //};
            //test1[2] = new TestClass()
            //{
            //    InputA = 15,
            //    ExpectedValue = 15,     //Ввод: 15 - Получаем: новый элемент со значение 15 добавился в дерево (является листом) [Left = null] [Right = null] [Parent = 20]
            //                            //Находится в левой части
            //};
            //test1[3] = new TestClass()
            //{
            //    InputA = 34,
            //    ExpectedValue = 34,     //Ввод: 34 - Получаем: новый элемент со значение 34 добавился в дерево (является листом) [Left = null] [Right = null] [Parent = 35]
            //                            //Находится в левой части
            //};
            //test1[4] = new TestClass()
            //{
            //    InputA = 26,
            //    ExpectedValue = 26,     //Ввод: 26 - Получаем: новый элемент со значение 26 добавился в дерево (является листом) [Left = null] [Right = null] [Parent = 27]
            //                            //Находится в левой части
            //};
            ////Тестируем метод добавления узла в дерево
            //Console.WriteLine();
            //Console.WriteLine("AddItem(40)");
            //myTree.AddItem(test1[0].InputA);
            //myTree.PrintMethodThree(myTree);
            //Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("AddItem(28)");
            //myTree.AddItem(test1[1].InputA);
            //myTree.PrintMethodThree(myTree);
            //Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("AddItem(15)");
            //myTree.AddItem(test1[2].InputA);
            //myTree.PrintMethodThree(myTree);
            //Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("AddItem(34)");
            //myTree.AddItem(test1[3].InputA);
            //myTree.PrintMethodThree(myTree);
            //Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("AddItem(26)");
            //myTree.AddItem(test1[4].InputA);
            //myTree.PrintMethodThree(myTree);
            //Console.ReadKey();
            //Console.Clear();

            ////ТЕСТ - 2
            //Console.WriteLine("ТЕСТ-2 - Поиск узла по значению");
            //var test2 = new TestClass[4];
            //test2[0] = new TestClass()
            //{
            //    InputA = 35,
            //    ExpectedValue = 35,
            //};
            //test2[1] = new TestClass()
            //{
            //    InputA = 27,
            //    ExpectedValue = 27,
            //};
            //test2[2] = new TestClass()
            //{
            //    InputA = 30,
            //    ExpectedValue = 30,
            //};
            //test2[3] = new TestClass()
            //{
            //    InputA = 41,
            //    ExpectedValue = 41,
            //};
            ////Тестируем метод поиска узла по значению
            //for (int i = 0; i < test2.Length; i++)
            //{
            //    var res = myTree.FindItem(test2[i].InputA);
            //    Console.WriteLine($"InputA: {res.Data} ExpectedValue: {test2[i].ExpectedValue}");
            //    Console.ReadKey();
            //}
            //Console.Clear();

            ////TECT - 3
            //Console.WriteLine("ТЕСТ-3 - Удаление узла по значению");
            //var test3 = new TestClass[3];
            //test3[0] = new TestClass()
            //{ 
            //    InputA = 50,
            //    ExpectedValue = 0,
            //};
            //test3[1] = new TestClass()
            //{
            //    InputA = 25,
            //    ExpectedValue = 0,
            //};
            //test3[2] = new TestClass()
            //{
            //    InputA = 30,
            //    ExpectedValue = 0,
            //};
            //Console.WriteLine("КАРТА ДО УДАЛЕНИЯ");
            //Console.WriteLine();
            //myTree.PrintMethodThree(myTree);
            ////Тестируем (самое интересное) - метод удаления узла по значению
            //for (int i = 0; i < test3.Length; i++)
            //{
            //    Console.WriteLine($"RemoveItem({test3[i].InputA})");
            //    Console.WriteLine();
            //    myTree.RemoveValue(test3[i].InputA);
            //    myTree.PrintMethodThree(myTree);
            //    Console.ReadKey();
            //}
            //Console.Clear();

            //Console.WriteLine("Метод 1 вывода дерева");
            //Console.WriteLine();
            //myTree.PrintMethodOne(myTree);
            //Console.ReadKey();
            //Console.WriteLine("Метод 2 вывода дерева");
            //Console.WriteLine();
            //myTree.PrintMethodTwo(myTree, 15);
            //Console.ReadKey();
            //Console.WriteLine("Метод 3 вывода дерева");
            //Console.WriteLine();
            //myTree.PrintMethodThree(myTree);
            //Console.ReadKey();
            //Console.Clear();

            ////ТЕСТ - 4
            //var test4 = new TestClass[4];
            //test4[0] = new TestClass()
            //{
            //    InputA = 5,
            //};
            //test4[1] = new TestClass()
            //{
            //    InputA = 10,
            //};
            //test4[2] = new TestClass()
            //{
            //    InputA = 15,
            //};
            //test4[3] = new TestClass()
            //{
            //    InputA = 20,
            //};
            //Console.WriteLine("ТЕСТ-4 - Построение сбалансированного дерева");
            //var newTree = new Node();
            //for (int i = 0; i < test4.Length; i++)
            //{
            //    Console.WriteLine($"Дерево на {test4[i].InputA} элементов");
            //    newTree = Node.TreeAuto(test4[i].InputA);
            //    newTree.PrintMethodThree(newTree);
            //    Console.ReadKey();
            //}

            //Задание к 5 уроку.
            var myNewTree = new Node();
            myNewTree.AddItem(30);
            myNewTree.AddItem(25);
            myNewTree.AddItem(41);
            myNewTree.AddItem(20);
            myNewTree.AddItem(27);
            myNewTree.AddItem(50);
            myNewTree.AddItem(35);
            myNewTree.AddItem(61);
            myNewTree.AddItem(40);
            myNewTree.AddItem(28);
            myNewTree.AddItem(15);
            myNewTree.AddItem(34);
            myNewTree.AddItem(26);
            myNewTree.PrintMethodThree(myNewTree);

            //Тестируем DFS метод поиска
            var test5 = new TestClass[5];
            test5[0] = new TestClass()
            {
                InputA = 25,
                ExpectedValue =25,
            };
            test5[1] = new TestClass()
            {
                InputA = 28,
                ExpectedValue = 28,
            };
            test5[2] = new TestClass()
            {
                InputA = 40,
                ExpectedValue = 40,
            };
            test5[3] = new TestClass()
            {
                InputA = 61,
                ExpectedValue = 61,
            };
            test5[4] = new TestClass()
            {
                InputA = 30,
                ExpectedValue = 30,
            };
            Console.WriteLine();
            Console.WriteLine("ПОИСК - DFS");
            for (int i = 0; i < test5.Length; i++)
            {
                var dfs = myNewTree.DFSsearch(myNewTree, test5[i].InputA);
                for (int j = 0; j < dfs.Length; j++)
                {
                    Console.WriteLine($"Значения - [{dfs[j].Node.Data}] Глубина поиска - [{dfs[j].Depth}]");
                    Console.ReadKey();
                }
            }
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("ПОИСК - BFS");
            myNewTree.PrintMethodThree(myNewTree);
            for (int i = 0; i < test5.Length; i++)
            {
                var bfs = myNewTree.BFSsearch(myNewTree, test5[i].InputA);
                for (int j = 0; j < bfs.Length; j++)
                {
                    Console.WriteLine($"Значения - [{bfs[j].Node.Data}] Глубина поиска - [{bfs[j].Depth}]");
                    Console.ReadKey();
                }
            }
            Console.ReadKey();
        }
    }
}
