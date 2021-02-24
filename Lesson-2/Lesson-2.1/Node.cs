using System;
using System.Collections.Generic;
using System.Text;
using Lesson_1._1;

namespace Lesson_2._1
{
    /// <summary>
    /// Класс "узлов" двусвязного списка
    /// </summary>
    public class Node
    {
        public int Value { get; set; }
        public Node NextItem { get; set; }
        public Node PrevItem { get; set; }
    }

    /// <summary>
    /// Класс реализует интерфейс двусвязного списка
    /// </summary>
    public class LinkedList : IlinkedList
    {
        private Node HeadNode; //Начальный элемент списка
        private Node TailNode; //Конечный элемент списка
        private int count; //Счетчик количества добавленных элементов

        /// <summary>
        /// Метод добавляет новый элемент в двусвязный список
        /// </summary>
        /// <param name="value"></param>
        public void AddNode(int value)
        {
            var newNode = new Node { Value = value };

            //Запись первого (головного элемента) если ничего нет
            if (HeadNode == null)
            {
                HeadNode = newNode;
            }
            //Продвигаемся вперед записывая в последний элемент Tail
            else
            {
                TailNode.NextItem = newNode;
                newNode.PrevItem = TailNode;
            }
            //Записываем также и "хвост"
            TailNode = newNode;
            count++;
        }

        /// <summary>
        /// Добавляет новый элемент после определенного элемента в двусвязный список
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        public void AddNodeAfter(Node node, int value)
        {
            Node currentNode = HeadNode; //Текущий объект
            Node previousNode = null; //Предыдущий объект
            var newNode = new Node { Value = value }; //Новая нода

            //Продвигается с начала списка в конец
            while (currentNode != null)
            {
                //Если текущий объект совпадает
                if (currentNode == node)
                {
                    //Если вставляем в середине
                    if (previousNode != null)
                    {
                        var nodeNext = currentNode.NextItem;
                        currentNode.NextItem = newNode;

                        node.NextItem = newNode;
                        newNode.NextItem = nodeNext;
                        newNode.PrevItem = currentNode;
                        //Если вставляем в конец
                        if (currentNode.NextItem.NextItem == null)
                        {
                            TailNode = newNode;
                        }
                        else
                        {
                            nodeNext.PrevItem = newNode;
                        }
                    }
                    //Если вставляем в самое начало
                    else
                    {
                        //На место первого становится вставляемый элемент
                        newNode.NextItem = HeadNode;
                        HeadNode = newNode;

                        //Проверка пустой ли список
                        if (HeadNode == null)
                        {
                            TailNode = null;
                        }
                        else
                        {
                            currentNode.PrevItem = newNode;
                        }
                    }
                    count++;
                    return;
                }
                //итератор -->
                previousNode = currentNode;
                currentNode = currentNode.NextItem;
            }
        }

        /// <summary>
        /// Ищет элемент по его значению
        /// </summary>
        /// <param name="searchValue"></param>
        /// <returns></returns>
        public Node FindNode(int searchValue)
        {
            //Начальный объект
            var currentNode = HeadNode;
            //Двигаемся от начала до конца
            while (currentNode != null)
            {
                //Если заданное значение совпадает с текущим объектом
                if (currentNode.Value == searchValue)
                {
                    return currentNode;
                }
                //Итератор -->
                currentNode = currentNode.NextItem;
            }
            return null;
        }

        /// <summary>
        /// Возвращает количество добавленных элементов
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return count;
        }

        /// <summary>
        /// Метод выводит "список" в консоль
        /// </summary>
        public void PrintList()
        {
            int index = 0;
            var currentNode = HeadNode;
            while (currentNode != null)
            {
                index++;
                if (currentNode.PrevItem == null)
                {
                    Console.WriteLine("null<-[PrevItem]");
                }
                Console.WriteLine($"<- [PrevItem] [index] {index} [{currentNode.Value}] [NextItem] ->");
                if (currentNode.NextItem == null)
                {
                    Console.WriteLine("[NextItem] ->null");
                }
                currentNode = currentNode.NextItem;
            }
            Console.WriteLine();
            Console.WriteLine($"Общее количество элементов: {GetCount()}");
        }

        /// <summary>
        /// Удаление элемента по порядковому номеру
        /// </summary>
        /// <param name="index"></param>
        public void RemoveNode(int index)
        {
            Node currentNode = HeadNode; //Текущий объект
            Node previousNode = null; //Предыдущий объект
            int _index = 0;
            
            //Продвигается с начала списка в конец
            while (currentNode != null)
            {
                _index++;
                //Если текущий индекс совпадает с удаляемым
                if (_index == index - 1)
                {
                    //Удаляемый элемент в середине или предпоследний
                    if (previousNode != null)
                    {
                        //пересоединяем ссылку на следующий элемент
                        previousNode.NextItem = currentNode.NextItem;

                        //Если элемент в конце
                        if (currentNode.NextItem == null)
                        {
                            TailNode = previousNode;
                        }
                        else
                        {
                            //Пересоединяем ссылку на предыдущий элемент
                            currentNode.NextItem.PrevItem = previousNode;
                        }
                    }
                    //Если удаляемый элемент первый
                    else
                    {
                        //То следующий элемент за первым становится первым
                        HeadNode = HeadNode.NextItem;
                        HeadNode.PrevItem = null;

                        //Проверка пустой ли список
                        if (HeadNode == null)
                        {
                            TailNode = null;
                        }
                    }
                    count--;
                    return;
                }
                //итератор -->
                previousNode = currentNode;
                currentNode = currentNode.NextItem;
            }
        }

        /// <summary>
        /// Удаление по указанному элементу
        /// </summary>
        /// <param name="node"></param>
        public void RemoveNode(Node node)
        {
            Node currentNode = HeadNode; //Текущий объект
            Node previousNode = null; //Предыдущий объект

            //Продвигается с начала списка в конец
            while (currentNode != null)
            {
                //Если текущий объект совпадает с удаляемым
                if (currentNode == node)
                {
                    //Удаляемый элемент в середине или предпоследний
                    if (previousNode != null)
                    {
                        //пересоединяем ссылку на следующий элемент
                        previousNode.NextItem = currentNode.NextItem;

                        //Если элемент в конце
                        if (currentNode.NextItem == null)
                        {
                            TailNode = previousNode;
                        }
                        else
                        {
                            //Пересоединяем ссылку на предыдущий элемент
                            currentNode.NextItem.PrevItem = previousNode;
                        }
                    }
                    //Если удаляемый элемент первый
                    else
                    {
                        //То следующий элемент за первым становится первым
                        HeadNode = HeadNode.NextItem;
                        HeadNode.PrevItem = null;

                        //Проверка пустой ли список
                        if (HeadNode == null)
                        {
                            TailNode = null;
                        }
                    }
                    count--;
                    return;
                }
                //итератор -->
                previousNode = currentNode;
                currentNode = currentNode.NextItem;
            }
        }
    }
    public interface IlinkedList
    {
        int GetCount(); //Возвращает кол-во элементов в списке
        void AddNode(int value); //Добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); //Добавляет новый элемент списка после определенного элемента
        void RemoveNode(int index); //Удаляет элемент по порядковому номеру
        void RemoveNode(Node node); //Удаляет указанный элемент
        void PrintList(); //Метод выводит "список" в консоль
        Node FindNode(int searchValue); //Ищет элемент по его значению
    }
}
