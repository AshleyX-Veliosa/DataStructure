namespace Queue
{
    public interface Queues
    {
        bool isEmpty();
        int size();
        void enqueue(object e);
        object dequeue();
        object peek();
    }

}
