using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace block2__ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedLisy l = new MyLinkedLisy(new Node { Value = 100 });
            l.AddNode(10);
            l.AddNode(5);
            l.AddNode(7);
            return;
        }

        public class Node
        {
            public int Value { get; set; }
            public Node NextNode { get; set; }
            public Node PrevNode { get; set; }
        }

        //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
        public interface ILinkedList
        {
            int GetCount(); // возвращает количество элементов в списке
            void AddNode(int value);  // добавляет новый элемент списка
            void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
            void RemoveNode(int index); // удаляет элемент по порядковому номеру
            void RemoveNode(Node node); // удаляет указанный элемент
            Node FindNode(int searchValue); // ищет элемент по его значению
        }


        class MyLinkedLisy : ILinkedList
        {
            private Node head;

            public MyLinkedLisy(int rootValue)
            {
                head = new Node { Value = rootValue };
            }

            public void AddNode(int value)
            {
                Node r = head;
                while(r.NextNode != null)
                { 
                    r = r.NextNode;
                }
                r.NextNode = new Node() { Value = value };
            }

            public void AddNodeAfter(Node node, int value)
            {
                throw new NotImplementedException();
            }

            public Node FindNode(int searchValue)
            {
                Node r = head;
                while(r!=null)
                {
                    if (r.Value == searchValue) return r;
                    r = r.NextNode;
                }
                return null;
            }

            public int GetCount()
            {
                Node r = head;
                int c = 0;
                while (r != null)
                {
                    c++;
                    r = r.NextNode;
                }
                return c;
            }

            public void RemoveNode(int index)
            {
                throw new NotImplementedException();
            }

            ppublic void RemoveNode(Node node)
            {
                throw new NotImplementedException();
            }

            public void Print()
            {
                Node r = head;

                while (r != null)
                {
                    Console.WriteLine(r.Value);
                    r = r.NextNode;
                }

            }

        }


    }
}

