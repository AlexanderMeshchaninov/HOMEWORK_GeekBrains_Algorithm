using System;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание первое

            //Граф в данной реализации выглядит как бинарное дерево:
            //                                                __(V1)__
            //                                            (V2)        (V6)
            //                                            /  |         |  \
            //                                         (V3)  |         |  (V8)   
            //                                              (V4)      (V7)
            //                                               |
            //                                              (V5)

            var graph = new Graph();

            //Создание 8 вершин
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);
            var v8 = new Vertex(8);

            //Добавляем вершины в граф
            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);
            graph.AddVertex(v8);

            //Добавляем ребра в между вершинами в граф
            graph.AddEdge(v1, v2);
            graph.AddEdge(v2, v3);
            graph.AddEdge(v2, v4);
            graph.AddEdge(v4, v5);
            graph.AddEdge(v1, v6);
            graph.AddEdge(v6, v7);
            graph.AddEdge(v6, v8);

            //Матрица смежностей
            graph.PrintMatrix(graph);
            Console.ReadKey();
            Console.Clear();

            //Список смежностей
            Console.WriteLine();
            Console.WriteLine("Cписок смежностей");
            Console.WriteLine();
            graph.PrintVertex(v1);
            graph.PrintVertex(v2);
            graph.PrintVertex(v3);
            graph.PrintVertex(v4);
            graph.PrintVertex(v5);
            graph.PrintVertex(v6);
            graph.PrintVertex(v7);
            graph.PrintVertex(v8);
            Console.ReadKey();
            Console.Clear();

            //TECT1
            var test1 = new TestClass[4];
            test1[0] = new TestClass()
            { 
                InputA = 8,
                InputB = v1,            //Вершина с которой стартуем
                ExpectedValue = 8,
            };
            test1[1] = new TestClass()
            {
                InputA = 4,
                InputB = v2,
                ExpectedValue = 4,
            };
            test1[2] = new TestClass()
            {
                InputA = 2,
                InputB = v1,
                ExpectedValue = 2,
            };
            test1[3] = new TestClass()
            {
                InputA = 5,
                InputB = v2,
                ExpectedValue = 5,
            };
            //Тестируем BFS для графа
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine($"Поиск с элемента начинается с: [{test1[i].InputB}] - Ожидаем: [{test1[i].InputA}]");
                graph.BFSsearch(test1[i].InputB, test1[i].InputA);
                Console.ReadKey();
                Console.Clear();
                //Есть косяк с экземплярами Vertex - если не выходить из консоли и начать закидывать в метод новые параметры то свойство класса
                //Vertex не обновляется: Visited = true;
                //Поэтому пришлось (пока не знаю как решить), сделать костыли... :-(
                v1.Visited = false;
                v2.Visited = false;
                v3.Visited = false;
                v4.Visited = false;
                v5.Visited = false;
                v6.Visited = false;
                v7.Visited = false;
                v8.Visited = false;
            }
            //Тестируем DFS для графа
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine($"Поиск с элемента начинается с: [{test1[i].InputB}] - Ожидаем: [{test1[i].InputA}]");
                graph.DFSsearch(test1[i].InputB, test1[i].InputA);
                Console.ReadKey();
                Console.Clear();
                //Есть косяк с экземплярами Vertex - если не выходить из консоли и начать закидывать в метод новые параметры то свойство класса
                //Vertex не обновляется: Visited = true;
                //Поэтому пришлось (пока не знаю как решить), сделать костыли... :-(
                v1.Visited = false;
                v2.Visited = false;
                v3.Visited = false;
                v4.Visited = false;
                v5.Visited = false;
                v6.Visited = false;
                v7.Visited = false;
                v8.Visited = false;
            }
            Console.WriteLine("Благодарю за просмотр :-)");
            Console.ReadKey();
        }
    }
}
