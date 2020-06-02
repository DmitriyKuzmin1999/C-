using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_10
{
    public interface IQueue<T>:IEnumerable<T>
    {
        //методы
        void Push(T value);
        void Clear();
        T Pop();
        T Peek();
        //свойства
        int Count { get; set; }
        bool IsEmpty { get; }

    }
}
