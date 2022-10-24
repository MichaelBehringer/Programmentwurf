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
            MyList<Pokemon> myPokedex = generatePokedexFromExcel("pokemonSmall.csv");
            myQueue<Digimon> myDigidex = generateDigiedexFromExcel("digimonSmall.csv");

            //Method 1
            Console.WriteLine("--- Method 1 ---");
            getPrimes(myPokedex);
            getPrimes(myDigidex);

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

        static void getPrimes(IEnumerable<MyIdentify> a)
        {
            foreach (MyIdentify p in a)
            {
                if(isPrime(p.Id, 2))
                {
                    Console.WriteLine(p);
                }
            }
        }

        static MyList<Pokemon> generatePokedexFromExcel(String path)
        {
            MyList<Pokemon> pokedex = new MyList<Pokemon>();
            string[] csvPokedex = File.ReadAllLines(path);
            foreach(string csvPokemon in csvPokedex)
            {
                string[] strings = csvPokemon.Split(';');
                pokedex.Add(new Pokemon(Convert.ToInt16(strings[0]), strings[1], strings[2], Convert.ToBoolean(strings[3])));
            }
            return pokedex;
        }

        static myQueue<Digimon> generateDigiedexFromExcel(String path)
        {
            myQueue<Digimon> digidex = new myQueue<Digimon>();
            string[] csvDigiedex = File.ReadAllLines(path);
            foreach (string csvDigimon in csvDigiedex)
            {
                string[] strings = csvDigimon.Split(';');
                digidex.Enqueue(new Digimon(Convert.ToInt16(strings[0]), strings[1], Convert.ToInt16(strings[2])));
            }
            return digidex;
        }

        static List<Pokemon> generatePrimePokedex(List<Pokemon> inputPokedex)
        {
            List<Pokemon> primePokedex = new List<Pokemon>();
            foreach (Pokemon pkm in inputPokedex)
            {
                if(isPrime(pkm.Id, 2))
                {
                    primePokedex.Add(pkm);
                }
            }
            return primePokedex;
        }

        static bool isPrime(int n, int i)
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
