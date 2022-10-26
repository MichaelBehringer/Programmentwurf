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
                if (isPrime(element.Id, 2))
                {
                    outputList.Add(element);
                }
            }
            return outputList;
        }

        private static bool isPrime(int n, int i)
        {

            // Base cases
            if (n <= 2)
                return (n == 2) ? true : false;
            if (n % i == 0)
                return false;
            if (i * i > n)
                return true;

            // Check for next divisor
            return isPrime(n, i + 1);
        }
    }
}
