using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{

    internal class FixedSizeList<T>
    {

        #region Attributes
        private readonly T[] items;
        private int count;
        #endregion

        #region Properties
        public int Capacity { get; }
        public int Count => count;
        #endregion

        #region Constructors

        public FixedSizeList() { }
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");

            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        } 
        #endregion


        public void Add(T item)
        {
            if (count >= Capacity)
                throw new InvalidOperationException("List is full.");

            items[count] = item;
            count++;
        }

       
        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index.");

            return items[index];
        }

        public override string ToString()
        {
            return $"FixedSizeList: Count={Count}, Capacity={Capacity}";
        }

    }
}
