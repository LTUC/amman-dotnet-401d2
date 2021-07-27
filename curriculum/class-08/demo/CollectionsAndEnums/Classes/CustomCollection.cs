using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndEnums.Classes
{
  class CustomCollection<T> : IEnumerable
  {
    // int[] items = new int[5];
    T[] items = new T[5];
    int count;

    public void Add(T item)
    {
      // Do we need to do resize the array?
      if (count == items.Length)
      {
        // resize it...
        Array.Resize(ref items, items.Length * 2);
      }

      items[count++] = item;
      // count++ vs ++count vs count+1

    }

    public IEnumerator<T> GetEnumerator()
    {
      for (int i = 0; i < count; i++)
      {
        yield return items[i];
      }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

  }
}