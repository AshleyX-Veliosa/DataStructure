namespace Collections
{
    public class ArrayCollection : Collection
    {
        private int cap, SIZE;
        private object[] data;
        public ArrayCollection(int cap)
        {
            this.cap = cap;
            data = new object[cap];
        }
        private void ensureCapacity()
        {
            if( SIZE + 1 > data.Length)
            {
                object[] temp = new object[cap * 2];
                for(int i = 0; i < SIZE; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
        }
        private int index0f(object e)
        {
            for(int i = 0; i < SIZE; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return -1;
        }
        public void add(object e)
        {
            ensureCapacity();
            data[SIZE++] = e;
        }

        public bool contains(object e)
        {
            return index0f(e) != -1;
        }

        public bool isEmpty()
        {
            return SIZE == 0;
        }

        public void remove(object e)
        {
            int i = index0f(e);
            if(i != -1)
            {
                data[i] = data[--SIZE];
                data[SIZE] = null;

            }
        }

        public int size()
        {
            return SIZE;
        }
    }
}
