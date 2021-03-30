using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._1
{
    public class Vertex
    {
        public bool Visited { get; set; }
        public int Number { get; set; } //Некое название вершины (цифровое)
        public Vertex(int number)
        {
            Number = number;
        }
        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
