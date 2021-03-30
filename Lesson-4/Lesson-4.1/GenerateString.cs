using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4._1
{
    public class GenerateString
    {
        private char GenerateChars(Random rnd)
        {
            return (char)(rnd.Next('A', 'Z' + 1));
        }
        /// <summary>
        /// Метод возвращает случайно сгенерированную строку
        /// </summary>
        /// <param name="rnd">Помещается экземпляр класса Random</param>
        /// <param name="length">Длинна строки</param>
        /// <returns></returns>
        public string GenerateStrings(Random rnd, int length)
        {
            char[] letters = new char[length];
            for (int i = 0; i < length; i++)
            {
                letters[i] = GenerateChars(rnd);
            }
            return new string(letters);
        }
    }
}
