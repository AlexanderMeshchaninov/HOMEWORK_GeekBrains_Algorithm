using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._1
{
    public class Graph
    {
        //Вершины
        List<Vertex> Vertexes = new List<Vertex>();
        //Ребра
        List<Edge> Edges = new List<Edge>();

        public int VertexCount => Vertexes.Count;
        public int EdgesCount => Edges.Count;

        /// <summary>
        /// Метод добавления вершин в список вершин
        /// </summary>
        public void AddVertex(Vertex vertex)
        {
            Vertexes.Add(vertex);
        }

        /// <summary>
        /// Поиска графа в грубину
        /// </summary>
        /// <param name="start">Начальная точка вершины</param>
        /// <param name="searchValue">Искомое значение</param>
        /// <returns></returns>
        public List<Vertex> DFSsearch(Vertex start, int searchValue)
        {
            Console.WriteLine("DFSsearch");
            Console.WriteLine();
            //Массив - очередь
            var bufer = new Stack<Vertex>();
            //Массив в который возвращается просмотренная вершина
            List<Vertex> returnArray = new List<Vertex>();
            //Помещаем вершину с которой начинается поиск
            bufer.Push(start);
            //Просто проверка пустой ли буфер
            if (bufer == null)
            {
                return null;
            }
            //Цикл работает до полного обнуления стека
            while (bufer.Count != 0)
            {
                //Извлекаем вершину
                var element = bufer.Pop();
                //Если значение вершины равна искомому элементу, то завершаем цикл
                if (element.Number == searchValue)
                {
                    element.Visited = true;
                    Console.WriteLine();
                    Console.WriteLine($"Искомый элемент: [{element.Number}] Посещен: [{element.Visited}] ");
                    break;
                }
                //Добавляем в массив элемент и ставим метку - посещен
                returnArray.Add(element);
                element.Visited = true;
                Console.WriteLine($"--> [{element.Number}] Посещен: [{element.Visited}]");
                //Ищем вершины, если не непосещали, то добавляем в очередь
                for (int i = 0; i < Edges.Count; i++)
                {
                    if (element == Edges[i].From)
                    {
                        if (Edges[i].To.Visited != true)
                        {
                            bufer.Push(Edges[i].To);
                        }
                    }
                }
            }
            return returnArray;
        }

        /// <summary>
        /// Волновой алгоритм поиска для графа
        /// </summary>
        /// <param name="start">Начальная точка вершины</param>
        /// <param name="searchValue">Искомое значение</param>
        /// <returns></returns>
        public List<Vertex> BFSsearch(Vertex start, int searchValue)
        {
            Console.WriteLine("BFSsearch");
            Console.WriteLine();
            //Массив - очередь
            var bufer = new Queue<Vertex>();
            //Массив в который возвращается просмотренная вершина
            var returnArray = new List<Vertex>();
            //Помещаем вершину с которой начинается поиск
            bufer.Enqueue(start);
            //Просто проверка пустой ли буфер
            if (bufer == null)
            {
                return null;
            }
            //Цикл работает до полного обнуления очереди
            while (bufer.Count != 0)
            {
                //Извлекаем вершину
                var element = bufer.Dequeue();
                //Если значение вершины равна искомому элементу, то завершаем цикл
                if (element.Number == searchValue)
                {
                    element.Visited = true;
                    Console.WriteLine();
                    Console.WriteLine($"Искомый элемент: [{element.Number}] Посещен: [{element.Visited}] ");
                    break;
                }
                else
                {
                    //Ищем соседние вершины с текущей вершиной, помещаем две смежные вершины в очередь
                    foreach (var edgesNear in Edges)
                    {
                        if (element == edgesNear.From)
                        {
                            bufer.Enqueue(edgesNear.To);
                        }
                    }
                    //Проверка, посещен ли был узел или нет
                    if (element.Visited != true)
                    {
                        returnArray.Add(element);
                        element.Visited = true;
                        Console.WriteLine($"--> [{element.Number}] [{element.Visited}]");
                    }
                }
            }
            return returnArray;
        }

        /// <summary>
        /// Метод добавления ребер в список ребер
        /// </summary>
        /// <param name="edge"></param>
        public void AddEdge(Vertex from, Vertex to)
        {
            var edge = new Edge(from, to);
            Edges.Add(edge);
        }
        
        /// <summary>
        /// Метод выводит "список смежностей"
        /// </summary>
        /// <param name="graph"></param>
        public void PrintVertex(Vertex vertex)
        {
            Console.Write($"[{vertex.Number}] -> ");
            foreach (var v in GetVertex(vertex))
            {
                Console.Write($"[{v}];");
            }
            Console.WriteLine();
        }
        private HashSet<Vertex> GetVertex(Vertex vertex)
        {
            var result = new HashSet<Vertex>();

            foreach (var edge in Edges)
            {
                if (vertex == edge.From)
                {
                    result.Add(edge.To);
                }
            }
            return result;
        }

        /// <summary>
        /// Метод выводящий в консоль "матрицу смежности"
        /// </summary>
        /// <param name="graph"></param>
        public void PrintMatrix(Graph graph)
        {
            Console.WriteLine("Матрица смежностей");
            Console.WriteLine();
            var matrix = graph.GetMatrix();
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write($"{i + 1} |");
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write(string.Format("{0, 3}", $"{matrix[i, j]}"));
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Метод выводит "матрицу смежности"
        /// </summary>
        /// <returns></returns>
        private int[,] GetMatrix()
        {
            var matrix = new int[Vertexes.Count, Vertexes.Count];

            foreach (var edge in Edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }
            return matrix;
        }
    }
}
