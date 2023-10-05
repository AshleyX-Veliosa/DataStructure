using System;
namespace Collections
{
    public class ArraySet : ArrayCollection, Set
    {
        public ArraySet(int cap) : base(cap) { }
        public new void add(Object e)
        {
            if (!base.contains(e))
            {
                base.add(e);
            }
        }
    }
}
