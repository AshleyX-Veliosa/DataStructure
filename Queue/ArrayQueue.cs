namespace Queue
{
    public class ArrayQueue : Queue
    {
        private object[] data;
        private int SIZE;
        private int cap;
        private int firstindex;
        public ArrayQueue(int cap)
        {
            this.cap = cap;
            data = new object[cap];
            SIZE = 0;
            firstindex = 0;
        }
        public object dequeue()
        {
            object e = peek();
            data[firstindex] = null;
            firstindex = (firstindex + 1) % data.Length;
            SIZE--;
            return e;
        }
        private void ensureCapacity()
        {
            object[] tempdata;
            if (SIZE + 1 > data.Length)
                //increase Capacity
                tempdata = new object[2 * data.Length];
            else if (data.Length > cap && data.Length > 2 * SIZE)
                //decrease Capacity
                tempdata = new object[data.Length / 2 + 1];
            else
                return;
            for (int i = 0, j = firstindex; i < SIZE; i++, j = (j + 1) % data.Length)
                tempdata[i] = data[j];
            firstindex = 0;
            data = tempdata;
        }

        public void enqueue(object e)
        {
            ensureCapacity();
            int k = (firstindex + SIZE) % data.Length;
            data[k] = e;
            SIZE++;
        }

        public bool isEmtpy()
        {
            return SIZE == 0;
        }

        public object peek()
        {
            if (isEmtpy())
                throw new System.MissingMemberException();
            return data[firstindex];
        }

        public int size()
        {
            return SIZE;
        }
    }
}
