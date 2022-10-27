using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class MyPrimeHelper
    {
        public static IEnumerable<MyIdentify> getPrimeCollection(IEnumerable<MyIdentify> inputCollection)
        {
            foreach (MyIdentify identify in inputCollection)
            {
                if (istPrimzahl(identify.Id))
                {
                    yield return identify;
                }
            }
        }

        public static bool istPrimzahl(int zahl)
        {
            if (zahl <= 1)
            {
                return false;
            }
            return istPrimzahl(zahl, 2);
        }

        public static bool istPrimzahl(int zahl, int temp)
        {
            if (zahl % temp == 0)
            {
                return zahl == temp;
            }
            return istPrimzahl(zahl, temp + 1);
        }
    }
}
