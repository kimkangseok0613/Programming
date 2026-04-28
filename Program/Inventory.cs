using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Program
{
    internal class Inventory<T> : IEnumerable
    {
        public T [] list;
        private int count = 0;

        public Inventory()
        {
            list = new T [5];
        }
        public void Add(T item)
        {
            if(count < list.Length)
            {
                list[count++] = item;
            }
            else
            {
                Console.WriteLine("Inventory is full");
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
