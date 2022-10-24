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
            //List<Pokemon> pokedex = new List<Pokemon>();
            ////pokedex.Add(new Pokemon(1, "Bisasam", "Pflanze", false));
            ////pokedex.Add(new Pokemon(4, "Glumanda", "Feuer", false));
            ////pokedex.Add(new Pokemon(5, "Glutexo", "Feuer", false));
            ////pokedex.Add(new Pokemon(7, "Schiggy", "Wasser", false));
            ////pokedex.Add(new Pokemon(11, "Safcon", "Kaefer", false));
            ////pokedex.Add(new Pokemon(12, "Smettbo", "Kaefer", false));
            ////pokedex.Add(new Pokemon(25, "Pikachu", "Elektro", false));
            ////pokedex.Add(new Pokemon(139, "Dragoran", "Drache", false));
            ////pokedex.Add(new Pokemon(263, "Zigzachs", "Normal", false));
            ////pokedex.Add(new Pokemon(865, "Lauchzelot", "Kampf", false));
            //pokedex = generatePokedexFromExcel("pokemon.csv");
            //List<Pokemon> primePokedex = generatePrimePokedex(pokedex);
            //primePokedex.ForEach(Console.WriteLine);
            ////File.WriteAllLines("ausgabe2.csv", generateOutputText(pokedex));
            ///
            MyList<Pokemon> myPokedex = new MyList<Pokemon>();
            myPokedex.Add(new Pokemon(1, "Bisasam", "Pflanze", false));
            myPokedex.Add(new Pokemon(4, "Glumanda", "Feuer", false));
            myPokedex.Add(new Pokemon(5, "Glutexo", "Feuer", false));
            myPokedex.Add(new Pokemon(7, "Schiggy", "Wasser", false));
            myPokedex.Add(new Pokemon(11, "Safcon", "Kaefer", false));
            myPokedex.Add(new Pokemon(12, "Smettbo", "Kaefer", false));

            getPrimes(myPokedex);

            //myPokedex.getPrimes().ForEach(Console.WriteLine);


            myQueue<Digimon> myDigidex = new myQueue<Digimon>();
            myDigidex.Enqueue(new Digimon(1, "Kuramon", 590));
            myDigidex.Enqueue(new Digimon(2, "Digi2", 592));
            myDigidex.Enqueue(new Digimon(3, "Digi3", 593));
            myDigidex.Enqueue(new Digimon(4, "Digi4", 594));
            myDigidex.Enqueue(new Digimon(5, "Digi5", 595));
            myDigidex.Enqueue(new Digimon(6, "Digi6", 596));
            myDigidex.Enqueue(new Digimon(7, "Digi7", 597));

            getPrimes(myDigidex);
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

        static List<string> generateOutputText(List<Pokemon> pokedex)
        {
            List<string> outputText = new List<string>();
            pokedex.ForEach(pkm => outputText.Add(pkm.ToCsv()));
            return outputText;
        }

        static List<Pokemon> generatePokedexFromExcel(String path)
        {
            List<Pokemon> pokedex = new List<Pokemon>();
            string[] csvPokedex = File.ReadAllLines(path);
            foreach(string csvPokemon in csvPokedex)
            {
                string[] strings = csvPokemon.Split(';');
                pokedex.Add(new Pokemon(Convert.ToInt16(strings[0]), strings[1], strings[2], Convert.ToBoolean(strings[3])));
            }
            return pokedex;
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
