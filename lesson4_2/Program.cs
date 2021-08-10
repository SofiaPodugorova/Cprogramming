using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();
            t.Insert("1");
            t.Insert("2");
            t.Insert("3");
            t.Insert("4");
            t.Insert("5");

            Console.WriteLine(t.Display(t));
            Tree s = t.Search("3");
            Console.WriteLine(s.Display(s));
            Console.Read();
        }

        class Tree
        {
            private string value;
            private int count;
            private Tree left;
            private Tree right;

            // вставка
            public void Insert(string value)
            {
                if (this.value == null)
                    this.value = value;
                else
                {
                    if (this.value.CompareTo(value) == 1)
                    {
                        if (left == null)
                            this.left = new Tree();
                        left.Insert(value);
                    }
                    else if (this.value.CompareTo(value) == -1)
                    {
                        if (right == null)
                            this.right = new Tree();
                        right.Insert(value);
                    }
                    else
                        throw new Exception("Узел уже существует");
                }

                this.count = Recount(this);
            }
            // поиск
            public Tree Search(string value)
            {
                if (this.value == value)
                    return this;
                else if (this.value.CompareTo(value) == 1)
                {
                    if (left != null)
                        return this.left.Search(value);
                    else
                        throw new Exception("Искомого узла в дереве нет");
                }
                else
                {
                    if (right != null)
                        return this.right.Search(value);
                    else
                        throw new Exception("Искомого узла в дереве нет");
                }
            }
            // отображение в строку
            public string Display(Tree t)
            {
                string result = "";
                if (t.left != null)
                    result += Display(t.left);

                result += t.value + " ";

                if (t.right != null)
                    result += Display(t.right);

                return result;
            }
            // подсчет
            private int Recount(Tree t)
            {
                int count = 0;

                if (t.left != null)
                    count += Recount(t.left);

                count++;

                if (t.right != null)
                    count += Recount(t.right);

                return count;
            }

            //удаление
            public void Remove(string value)
            {
                Tree t = Search(value);
                string[] str1 = Display(t).TrimEnd().Split(' ');
                string[] str2 = new string[str1.Length - 1];

                int i = 0;
                foreach (string s in str1)
                {
                    if (s != value)
                        str2[i++] = s;
                }
            }
        }
    }
}
