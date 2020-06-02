using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_10
{
    class LinkedQueue<T>:IQueue<T>
    {
        public class Node
        {
            internal T value;
            internal Node next;
            internal Node prev;

            public Node()
            {

            }

            public Node(T value, Node next)
            {
                this.value = value;
                this.next = next;
            }

            public T Value
            {
                get { return this.value; }

            }
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }

            public Node Prev
            {
                get { return this.prev; }
                set { this.prev = value; }
            }
        }

        public Node head;
        public Node tail;

        public LinkedQueue()
        {
            IsEmpty = true;
            Count = 0;
            head = null;
        }

        public LinkedQueue(IQueue<T> queue)
        {
            IsEmpty = true;
            Count = 0;
            head = null;
            foreach (T e in queue)
                Push(e);
        }

        public void Push(T value)
        {
            Node n = new Node();
            n.value = value;
            
            if (IsEmpty)
            {
                head = n;
                tail = head;
                IsEmpty = false;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
            Count++;     
        }

        public void Clear()          //функция очистки очереди
        {
            if (!IsEmpty)
            {
                head = null;
                tail = null;
                IsEmpty = true;
                Count = 0;
            }
        }

        public T Pop()
        {
            if (IsEmpty) throw new QueueException("Очередь пуста");
            else
            {
                T t = head.value;
                if (head.next == null)
                {
                    IsEmpty = true;
                    head = null;
                }
                else
                    head = head.next;
                Count--;
                if (Count == 0) IsEmpty = true;
                return t;
            }
        }

        public T Peek()
        {
            T t = head.value;
            return t;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (Node n = head; n != null; n = n.next)
                yield return n.value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count { get; set; }
        public bool IsEmpty { get; set; }
    }
}
