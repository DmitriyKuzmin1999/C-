using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_10
{
    class QueueUtils
    {
        public delegate bool CheckDelegate<T>(T value);// Представляет метод, который выполняет проверку значения value
        public delegate T ActionDeligate<T>(T value);// Представляет метод, который выполняет какие-либо действия со значением value
        public delegate TO ConvertDelegate<TI, TO>(TI value);// Представляет метод, ставящий в соответсвие значению value типа TI значение типа TO

        public delegate IQueue<T> QueueConstructorDelegate<T>() where T : System.IComparable<T>;// Представляет метод, возвращающий список IList

        public static IQueue<T> getArrayQueue<T>() where T : System.IComparable<T>
        {
            return new ArrayQueue<T>();
        }

        public static IQueue<T> getLinkedQueue<T>() where T : System.IComparable<T>
        {
            return new LinkedQueue<T>();
        }

        // Проверяет, есть ли в списке элементы, проходящие проверку методом check по значению
        public static bool Exists<T>(IQueue<T> queue, CheckDelegate<T> check) where T : System.IComparable<T>
        {
            foreach (T elem in queue)
                if (check(elem))
                    return true;
            return false;
        }

        // Возвращает список элементов, проходящих проверку check по значению
        public static IQueue<T> FindAll<T>(IQueue<T> queue, CheckDelegate<T> check, QueueConstructorDelegate<T> getEmptyQueue) where T : System.IComparable<T>
        {
            IQueue<T> result = getEmptyQueue();
            foreach (T elem in queue)
                if (check(elem))
                    result.Push(elem);
            return result;
        }

        // Конвертируем между Array и Linked
        public static IQueue<T> ConvertAll<T>(IQueue<T> Queue, QueueConstructorDelegate<T> construct) where T : IComparable<T>
        {
            IQueue<T> newQueue = construct();
            foreach (T value in Queue)
                newQueue.Push(value);
            return newQueue;
        }

        // Выполняет метод action для каждого элемента в списке
        public static void ForEach<T>(IQueue<T> queue, ActionDeligate<T> action) where T : System.IComparable<T>
        {
            int i = 0;
            T[] mas = new T[queue.Count];
            while(!queue.IsEmpty)
            {
                mas[i] = queue.Pop();
                i++;
            }
            i = 0;
            while (i != mas.Length)
            {
                queue.Push(action(mas[i]));
                i++;
            }
        }


        public static bool CheckForAll<T>(IQueue<T> queue, CheckDelegate<T> check) where T : System.IComparable<T>
        {
            foreach (T elem in queue)
                if (!check(elem))
                    return false;
            return true;
        }
    }
}
