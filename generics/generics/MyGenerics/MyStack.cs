using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.MyGenerics
{
    public class MyStack<T>
    {
        private int _position;

        private T[] _data = new T[1];

        public void Push(T obj)
        {
            if (_position == _data.Length)
            {
                var tempData = new T[_data.Length + 1];
                _data.CopyTo(tempData, 0);
                _data = tempData;
            }

            _data[_position++] = obj;
        }

        public T Pop()
        {
            if (_position - 1 < 0)
                throw new ArgumentNullException();

            var res = _data[--_position];
            var tempData = new T[_data.Length - 1];
            tempData = _data.Take(_data.Length - 1).ToArray();
            _data = tempData;

            return res;
        }

        public T Peek()
        {
            if (_position - 1 < 0)
                throw new ArgumentNullException();

            return _data[_position - 1];
        }
    }
}
