using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task31
{
    public class Circle<T> : IEnumerable<T>  // кольцевой связный список
    {
        private static int size = 10;
        private Node<T> head; // головной/первый элемент
        private Node<T> tail; // последний/хвостовой элемент
        private int count;  // количество элементов в списке

        // добавление элемента
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            // если список пуст
            if (Head == null)
            {
                Head = node;
                Tail = node;
                Tail.Next = Head;
            }
            else
            {
                node.Next = Head;
                Tail.Next = node;
                Tail = node;
            }
            count++;
        }
        public bool Remove(Node<T> n)
        {
            Node<T> current = Head;
            Node<T> previous = null;

            if (IsEmpty) return false;

            do
            {
                if (current.Equals(n))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если узел последний,
                        // изменяем переменную tail
                        if (current == Tail)
                            Tail = previous;
                    }
                    else // если удаляется первый элемент
                    {

                        // если в списке всего один элемент
                        if (count == 1)
                        {
                            Head = Tail = null;
                        }
                        else
                        {
                            Head = current.Next;
                            Tail.Next = current.Next;
                        }
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            } while (current != Head);

            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public Node<T> Head { get => head; private set => head = value; }
        public Node<T> Tail { get => tail; private set => tail = value; }
        public int Size
        {
            get => size;
            set
            {
                if (value > 0)
                    size = value;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = Head;
            if (current == null) return false;
            do
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            while (current != Head);
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Head;
            do
            {
                if (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }
            while (current != Head);
        }

        public static void FillList(Circle<int> list)
        {
            for (int i = 1; i <= size; i++)
            {
                list.Add(i);
            }
        }

        public void Show()
        {
            foreach (var item in this)
            {
                Console.WriteLine(item);
            }
        }
    }
}
