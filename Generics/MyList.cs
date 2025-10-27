using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    public class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
            Console.WriteLine("Constructorda 0 elemanlı dizi oluşturuldu");
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;

        }

        public void GetEach()
        {
            foreach (var i in _array)
            {
                Console.WriteLine(i);
            }
        }
        
        
        public int Count
        {
            get { return _array.Length; }
            
        }
        
    }
}