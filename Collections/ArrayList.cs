using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collections;

namespace Collections
{
    public class ArrayList : List
    {
        private object[] data;
        private int SIZE;
        private int cap;

        public ArrayList(int cap)
        {
            this.cap = cap;
            this.SIZE = 0;
            this.data = new object[cap];
        }

        public void add(int index, object e)
        {
            ensureCapacity();
            for (int i = SIZE; i > index; i--)
                data[i] = data[i - 1];
            data[index] = e;
            SIZE++;
        }
        private void ensureCapacity()
        {
            if (SIZE + 1 > data.Length)
            {
                object[] temp = new object[cap * 2];
                for (int i = 0; i < SIZE; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
        }

        public void add(object e)
        {
            add(SIZE, e);
        }

        public bool contains(object e)
        {
            return indexOf(e) != -1;
        }

        public object get(int index)
        {
            return data[index];
        }
        public void set(int index, object e)
        {
            data[index] = e;
        }

        public int indexOf(object e)
        {
            for (int i = 0; i < SIZE; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(int index)
        {
            if (index >= SIZE) return;
            for (int i = index + 1; i < SIZE; i++)
                data[i - 1] = data[i];
        }

        public void remove(object e)
        {
            int i = indexOf(e);
            if (i != -1)
                remove(i);
        }

        public int size()
        {
            return SIZE;
        }
    }
}
