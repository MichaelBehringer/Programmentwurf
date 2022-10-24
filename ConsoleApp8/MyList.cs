using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class MyList<T> : List<T> where T : MyIdentify
    {
        //public void Add(T value)
        //{
        //    base.Add(value);
        //}

        public MyList<T> getPrimes()
        {
            MyList<T> outputList = new MyList<T>();
            foreach (T line in this)
            {
                if (line.Id == 7)
                {
                    outputList.Add(line);
                }
            }
            return outputList;
        }
    }
}
