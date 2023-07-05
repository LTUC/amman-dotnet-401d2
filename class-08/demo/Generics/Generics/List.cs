using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class List
    {

        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }

    public class GenericList<T>
    {

        private List<T> items;


        public GenericList()
        {
            items = new List<T>();  
        }

        public void Add(T value)
        {
            items.Add(value);
        }

        //Indexer
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }

    //public class ObjectList
    //{
    //    public void Add(object value)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public object this[int index]
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}


}
