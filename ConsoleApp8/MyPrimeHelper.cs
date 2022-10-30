using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class MyPrimeHelper
    {
        //Generates IEnumerable Container only with prime numbers
        //input -  inputCollection: IEnumerable<MyIdentify>
        //output - primeCollection: IEnumerable<MyIdentify>
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

        //Checks if number is prime number
        //input -  number: integer
        //output - isPrimeNumber: boolean
        public static bool istPrimzahl(int zahl)
        {
            if (zahl <= 1)
            {
                return false;
            }
            return istPrimzahl(zahl, 2);
        }

        //Checks if number is prime number, recursive
        //input -  number: integer, tempNumber: integer
        //output - isPrimeNumber: boolean
        private static bool istPrimzahl(int zahl, int temp)
        {
            if (zahl % temp == 0)
            {
                return zahl == temp;
            }
            return istPrimzahl(zahl, temp + 1);
        }
    }
}
