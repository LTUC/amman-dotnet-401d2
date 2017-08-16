using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsExample
{
    enum Size: byte
    {
       Kids = 8,
       Tall = 12,
       Grande = 16,
       Venti = 20,
       Trentio = 31

    }

    public class Coffee : IEnumerable
    {
        public Coffee()
        {
            myData = new List<double>(new double[] { 3.4, 1.2, 6.2 });
        }

        private List<double> myData;

        public IEnumerator GetEnumerator()
        {
            foreach (double val in myData)
            {
                yield return val;
            }
        }
    }
}
