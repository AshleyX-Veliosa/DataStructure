namespace Queue
{
    public interface Queue
    {
        bool isEmtpy();
        int size();
        void enqueue(object e);
        object dequeue();
        object peek();
    }
}
