using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class MyList<T> : List<T> where T : MyIdentify
    {
        public MyList<T> getPrimes()
        {
            MyList<T> outputList = new MyList<T>();
            foreach (T element in this)
            {
                if (MyPrimeHelper.istPrimzahl(element.Id))
                {
                    outputList.Add(element);
                }
            }
            return outputList;
        }
    }
}
