using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary
{
    public interface IBag<T> : IEnumerable<T>
    {
        /// <summary>
        /// Add an item to the bag. <c>null</c> items are ignored.
        /// </summary>
        void Pack(T item);

        /// <summary>
        /// Remove the item from the bag at the given index.
        /// </summary>
        /// <returns>The item that was removed.</returns>
        T Unpack(int index);
    }

    public class Backpack<T> : IBag<T>
    {
        private readonly List<T> stuff = new List<T>();

        public void Pack(T item)
        {
            stuff.Add(item);
        }

        public T Unpack(int index)
        {
            T thing = stuff[index];
            stuff.RemoveAt(index);
            return thing;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T thing in stuff)
                yield return thing;

            // Or, more simply:
            // return stuff.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
