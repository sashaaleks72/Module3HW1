using System.Collections.Generic;

namespace Module3HW1
{
    public class IntegerComparator : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
}
