using System;

namespace Lesson_2._1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1:
            //Инициализация двусвязного списка
            LinkedList myList = new LinkedList();

            myList.AddNode(67);
            myList.AddNode(88);
            myList.AddNode(21);
            myList.AddNode(45);
            myList.AddNode(77);
            myList.AddNode(90);
            myList.AddNode(1);
            myList.AddNode(12);
            myList.AddNode(56);
            myList.AddNode(777);

            //TestClass, который использовал в предыдущем уроке.
            var test = new TestClass[4];
            test[0] = new TestClass()
            {
                InputA = 67,        //Ввод: 67, 1000 - Ожидается: Итог: 1000 --> 67
                InputB = 1000,
                ExpectedValue = 1000,
            };
            test[1] = new TestClass()
            {
                InputA = 45,        //Ввод: 45, 1000 - Ожидается: Итог: 45 --> 1000
                InputB = 1000,
                ExpectedValue = 1000,
            };
            test[2] = new TestClass()
            {
                InputA = 90,        //Ввод: 90, 1000 - Ожидается: Итог: 90 --> 1000
                InputB = 1000,
                ExpectedValue = 1000,
            };
            test[3] = new TestClass()
            {
                InputA = 777,       //Ввод: 777, 1000 - Ожидается: Итог: 777 --> 1000
                InputB = 1000,
                ExpectedValue = 1000,
            };
            //Тестируем метод AddNodeAfter(). Для нахождения нужного элемента используется метод - FindNode().
            myList.AddNodeAfter(myList.FindNode(test[0].InputA), test[0].InputB);
            myList.AddNodeAfter(myList.FindNode(test[1].InputA), test[1].InputB);
            myList.AddNodeAfter(myList.FindNode(test[2].InputA), test[2].InputB);
            myList.AddNodeAfter(myList.FindNode(test[3].InputA), test[3].InputB);
            Console.WriteLine("ТЕСТ 1");
            myList.PrintList();

            Console.ReadKey();

            var test1 = new TestClass[3];
            test1[0] = new TestClass()
            {
                InputA = 45,        //Ввод: 45 - Ожидается: Итог: удалится (45) 21 --> 1000
            };
            test1[1] = new TestClass()
            {
                InputA = 7,         //Ввод: индекса 7 (число 77) - Ожидается: Итог: удалится (77) 90 --> 1000
            };
            //Тестируем метод RemoveNode() - по индексу и по значению.
            myList.RemoveNode(myList.FindNode(test1[0].InputA));
            myList.RemoveNode(test1[1].InputA);
            Console.WriteLine("ТЕСТ 2");
            myList.PrintList();

            Console.ReadKey();
        }
    }
}
