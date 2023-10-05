using System;
using Lists;

namespace Queues
{
    public class LinkedListQueue : Queue
    {
        private List list = new DoublyLinkedList();
        public object dequeue()
        {
            object e = peek();
            list.remove(0);
            return e;
        }

        public void enqueue(object e)
        {
            list.add(e);
        }

        public bool isEmtpy()
        {
            return list.isEmpty();
        }

        public object peek()
        {
            if (isEmtpy())
                throw new System.MissingMemberException();
            return list.get(0);
        }

        public int size()
        {
            return list.size();
        }
    }
}
