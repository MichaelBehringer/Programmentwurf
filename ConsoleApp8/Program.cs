using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** 1788307 prime number algorithm ***");
            Console.WriteLine("\n\n");

            MyList<Pokemon> myPokedex = MyFileHelper.generatePokedexFromExcel("pokemonSmall.csv");
            MyQueue<Digimon> myDigidex = MyFileHelper.generateDigiedexFromExcel("digimonSmall.csv");

            //Input Data
            Console.WriteLine("--- Input Data ---");
            foreach (Pokemon pkm in myPokedex)
            {
                Console.WriteLine(pkm);
            }
            foreach (Digimon dig in myDigidex)
            {
                Console.WriteLine(dig);
            }

            Console.WriteLine("\n\n");

            //Method 1
            Console.WriteLine("--- Method 1 ---");
            foreach (Pokemon pkm in MyPrimeHelper.getPrimeCollection(myPokedex))
            {
                Console.WriteLine(pkm);
            }
            foreach (Digimon dig in MyPrimeHelper.getPrimeCollection(myDigidex))
            {
                Console.WriteLine(dig);
            }

            Console.WriteLine("\n\n");

            //Method 2
            Console.WriteLine("--- Method 2 ---");
            foreach (Pokemon pkm in myPokedex.getPrimes())
            {
                Console.WriteLine(pkm);
            }
            foreach (Digimon dig in myDigidex.getPrimes())
            {
                Console.WriteLine(dig);
            }
        }
    }
}
