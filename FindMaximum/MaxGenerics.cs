using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FindMaximumGenerics
{
    
        public class FindMaximum<T> where T : IComparable
        {
            public T[] array;
            public FindMaximum(T[] array)
            {
                this.array = array;
            }
            public T[] Sort()
            {
                Array.Sort(array);
                return array;
            }
            public T FindMaxValue()
            {
                T[] sorted = this.Sort();
                return sorted[sorted.Length - 1];
            }
        }   
}
   

