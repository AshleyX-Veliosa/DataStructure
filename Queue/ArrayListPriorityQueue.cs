using Lists;
using System;

namespace Queues
{
    public class ArrayListPriorityQueue : PriorityQueue
    {
        private List list;
        public ArrayListPriorityQueue(int cap)
        {
            list = new ArrayList(cap);
        }
        public object dequeue()
        {
            int i = HighestPriorityIndex();
            object e = list.get(i);
            list.remove(i);
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
        private int HighestPriorityIndex()
        {
            if (isEmtpy())
                throw new System.MissingMemberException();
            int i = 0;
            for (int j = 1; j < list.size(); j++)
            {
                IComparable c = (IComparable)list.get(j);
                if (c.CompareTo(list.get(i)) > 0)
                    i = j;
            }
            return i;
        }


        public object peek()
        {
            return list.get(HighestPriorityIndex());
        }

        public int size()
        {
            return list.size();
        }
    }
}   
