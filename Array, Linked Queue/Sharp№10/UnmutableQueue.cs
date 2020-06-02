using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_10
{
    class UnmutableQueue<T>:IQueue<T>
    {
        IQueue<T> UnmutQueue;

        public UnmutableQueue (IQueue<T> Queue)
        {
            UnmutQueue = Queue;
        }
        //методы
        public void Push(T value)
        {
            throw new QueueException("Нельзя изменять очередь неизменяемого типа");
        }

        public void Clear()
        {
            throw new QueueException("Нельзя изменять очередь неизменяемого типа");
        }

        public T Pop()
        {
            throw new QueueException("Нельзя изменять очередь неизменяемого типа");
        }

        public T Peek()
        {
            return UnmutQueue.Peek();
        }

        public int Count { get; set; }
        public bool IsEmpty { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return UnmutQueue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return UnmutQueue.GetEnumerator();
        }
    }
}
