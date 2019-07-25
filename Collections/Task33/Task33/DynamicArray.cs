using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task33

/*
 * 
 * Insert
 * 
 * 
 * */
{
    class DynamicArray<T> : IEnumerable<T>
    {
        private T[] array;
        private int capacity;
        private int length = 0;

        public DynamicArray()
        {
            Capacity = 8;
            array = new T[Capacity];
        }

        public DynamicArray(int capacity)
        {
            Capacity = capacity;
            array = new T[Capacity];
        }

        public DynamicArray(ICollection<T> collec)
        {
            Capacity = collec.Count + collec.Count / 2;
            Length = collec.Count;
            Array = new T[Capacity];
            if (collec != null) collec.CopyTo(Array, 0);
            else throw new ArgumentNullException(nameof(array));
        }
        public void Add(T elem)
        {
            if (!isEnoughCapacity())
            {
                Capacity += Capacity / 2;
                Array = ExpandArray(Capacity);
            }
            array[length] = elem;
            Length++;
        }

        public void AddRange(ICollection<T> collec)
        {
            if (!isEnoughCapacity())
            {
                Capacity += collec.Count + collec.Count / 2;
                Array = ExpandArray(Capacity);
            }
            Length += collec.Count;
            collec.CopyTo(Array, Length - collec.Count);

        }

        public T[] ExpandArray(int capacity)
        {
            T[] temp = new T[capacity];
            Array.CopyTo(temp, 0);
            return temp;
        }

        public bool Insert(T elem,int position)
        {
            if(position<length&&position>=0)
            {
                if(!isEnoughCapacity())
                {
                    Capacity += Capacity / 2;
                    Array = ExpandArray(Capacity);
                }
                Length++;
                for(int j=length-1;j>position;j--)
                {
                    Array[j] = Array[j - 1];
                }
                Array[position] = elem;
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Выход за границу массива");
            }
        }



        public bool Remove(T elem)
        {
            if(!elem.Equals(default(T)))
            {
                for(int i=0;i<Length;i++)
                {
                    if (Array[i].Equals(elem))
                    {
                        if (i < Length - 1)
                        {
                            for (int j = i; j < Length - 1; j++)
                            {
                                Array[j] = Array[j + 1];
                            }
                        }
                        Length--;
                        Array[Length] = default(T);
                        
                        return true;
                    }
                   
                }
                return false;
            }
            else
            {
                throw new NullReferenceException(nameof(array));
            }
        }

        public int Capacity { get => capacity; set => capacity = value; }
        public T[] Array { get => array; set => array = value; }
        public int Length { get => length; set => length = value; }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            int i = 0;
            T current = Array[i];
            do
            {
                if (current != null)
                {
                    yield return current;
                    current = array[++i];
                }
            }
            while (i < Length);
        }
        public T this[int id]
        {

            get
            {
                if (isInTheBorder(id)) return Array[id];
                else throw new ArgumentOutOfRangeException("Выход за границу массива");
            }
            set
            {
                if (isInTheBorder(id) && value.Equals(default(T))) Array[id] = value;
                else throw new ArgumentOutOfRangeException("Выход за границу массива");
            }
        }
        private bool isInTheBorder(int i)
        {
            return i >= 0 && i < Length;
        }

        private bool isEnoughCapacity()
        {
            return Length < Capacity;
        }

    }
}



