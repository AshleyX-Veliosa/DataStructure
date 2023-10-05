namespace Collections
{
    public class LinkedSet : LinkHeaderCollections, Set
    {
        public new void add(object e)
        {
            if (!base.contains(e))
            {
                base.add(e);
            }
        }
    }
}
