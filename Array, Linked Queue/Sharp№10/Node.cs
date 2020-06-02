using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_10
{
    class Node<T>
    {
        private T _content;
        private Node<T> _next;

        public T Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public Node(T content)
        {
            _content = content;
        }

        public Node<T> Next
        {
            get { return this._next; }
            set { this._next = value; }
        }
    }
}
