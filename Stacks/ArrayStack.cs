namespace Stacks
{
    public class ArrayStack : Stack
    {
        private object[] data;
        private int SIZE;
        private int cap;

        public ArrayStack(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        public bool isEmpty()
        {
            return SIZE == 0;
        }
        public int size()
        {
            return SIZE;
        }
        public void push(object e)
        {
            ensureCapacity();
            data[SIZE++] = e;
        }
        public object peek()
        {
            if(isEmpty())
                throw new System.MissingMemberException();
            return data[SIZE - 1];
        }
        public object pop()
        {
            object e = peek();
            data[--SIZE] = null;
            return e;
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
    }
}
