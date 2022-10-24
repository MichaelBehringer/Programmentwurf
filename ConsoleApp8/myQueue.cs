using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class myQueue<T> : Queue<T> where T : MyIdentify
    {
        public myQueue<T> getPrimes()
        {
            myQueue<T> outputQueue = new myQueue<T>();
            foreach (T line in this)
            {
                if (line.Id == 11)
                {
                    outputQueue.Enqueue(line);
                }
            }
            return outputQueue;
        }
    }
}
