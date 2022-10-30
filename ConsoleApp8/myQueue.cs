using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class MyQueue<T> : Queue<T> where T : MyIdentify
    {
        //Generates MyQueue only with prime numbers
        //input  /
        //output - primeMyQueue: MyQueue<T>
        public MyQueue<T> getPrimes()
        {
            MyQueue<T> outputQueue = new MyQueue<T>();
            foreach (T element in this)
            {
                if (MyPrimeHelper.istPrimzahl(element.Id))
                {
                    outputQueue.Enqueue(element);
                }
            }
            return outputQueue;
        }
    }
}
