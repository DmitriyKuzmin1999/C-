using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_10
{
    class ArrayQueue<T> : IQueue<T>
    {
        private const int n = 10;
        private int head, tail;
        private T[] a;

        public ArrayQueue()
        {
            IsEmpty = true;
            Count = 0;
            a = new T[n];
            head = 0;
            tail = 0;
        }

        public ArrayQueue(IQueue<T> queue)
        {
            IsEmpty = true;
            a = new T[n];
            Count = 0;
            head = 0;
            tail = 0;
            foreach (T e in queue)
                Push(e);
        }

        public void Push(T value)
        {
            if (Count == n) throw new QueueException("В массиве больше нет места");
            else
            {
                a[tail] = value;
                if (tail == n - 1) tail = 0;
                else tail++;
                Count++;
                IsEmpty = false;
            }
        }

        public void Clear()          //функция очистки очереди
        {
            head = 0;
            tail = 0;
            Count = 0;
            IsEmpty = true;
            a[0] = default(T);
        }

        public T Pop()
        {
            if (Count > 0)
            {
                T t = a[head];
                head++;
                Count--;
                if (head > n - 1) head = 0;
                if (Count == 0) IsEmpty = true;
                return t;
            }
            else
            {
                throw new QueueException("Очередь пуста");
            }
        }

        public T Peek()
        {
            if (Count > 0)
            {
                T t = a[head];
                return t;
            }
            else
            {
                throw new QueueException("Очередь пуста");
            }
        }

        public int Count { get; set; }
        public bool IsEmpty { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = head; i < tail; i++)
                yield return a[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
