using System.Collections.Generic;

namespace Module3HW1
{
    public interface IMyList<T> : IEnumerable<T>
    {
        public int Count { get; }
        public int Capacity { get; }
        public T this[int index] { get; set; }
        public void Add(T value);
        public void AddRange(params T[] values);
        public bool Remove(T value);
        public void RemoveAt(int index);
        public void Sort(IComparer<T> comparer);
    }
}
