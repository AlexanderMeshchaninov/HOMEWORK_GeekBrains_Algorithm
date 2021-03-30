using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    public class Board
    {
        public int N { get; set; } //Количество строк
        public int M { get; set; } //Количество столбцов

        public Board(int row, int column)
        {
            N = row;
            M = column;
        }

        /// <summary>
        /// Метод вывода доски (матрицы) на экран
        /// </summary>
        public void PrintBoard(int[,] map)
        {
            Console.WriteLine("Количество маршрутов");
            Console.WriteLine();
            for (int i = 0; i < M; i++)
            {
                Console.Write("---+");
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    var result = map[i, j];
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                    if (map[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("{0, 3}", result);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|");
                Console.Write("\r\n");
            }
            for (int i = 0; i < M; i++)
            {
                Console.Write("+---");
            }
        }

        /// <summary>
        /// Метод устанавливает карту
        /// </summary>
        /// <param name="barrierOn">Включить препятствия/выключить препятствия на карте(по-умолчанию вкл)</param>
        public int[,] InstallBoardWithBarrier(Board board, int barrierOn = 1)
        {
            //Карта доски
            int[,] map = new int[N, M];
            //Карта барьеров (если 1 - то барьера нет в данной точке, если 0 - то барьер есть)
            int[,] barrier = new int[N, M];

            for (int j = 0; j < M; j++)
            {
                //Цикл устанавливает 1 слева направо (верхняя часть доски)
                map[0, j] = 1;
            }
            for (int i = 1; i < N; i++)
            {
                //Цикл устанавливает 1 сверху вниз (левая часть доски)
                map[i, 0] = 1;

                for (int j = 1; j < M; j++)
                {
                    
                    if (barrierOn == 1)
                    {
                        barrier[i, j] = 1;
                        //Препятствие вкл
                        barrier[4, 2] = 0;
                        barrier[2, 4] = 0;
                        barrier[2, 6] = 0;
                    }
                    if (barrierOn == 0)
                    {
                        barrier[i, j] = 1;
                        //Препятствие выкл
                        barrier[4, 2] = 1;
                        barrier[2, 4] = 1;
                        barrier[2, 6] = 1;
                    }
                    //Тут немного не понял.
                    //Если убрать условие (хотя по дебагу в любом случае есть проход по рекурентной формуле), то функционал ломается и барьеры не выводятся
                    //При данной реализации все работает
                    if (barrier[i, j] == 1)
                    {
                        map[i, j] = map[i, j - 1] + map[i - 1, j];
                    }
                }
            }
            return map;
        }
    }
}
