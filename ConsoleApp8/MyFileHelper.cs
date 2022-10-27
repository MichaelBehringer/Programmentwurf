using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class MyFileHelper
    {
        public static MyList<Pokemon> generatePokedexFromExcel(String path)
        {
            MyList<Pokemon> pokedex = new MyList<Pokemon>();
            string[] csvPokedex = { };
            try
            {
                csvPokedex = File.ReadAllLines(path);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Eingabedatei Pokemon kann nicht gefunden werden");
                return new MyList<Pokemon>();
            }

            foreach (string csvPokemon in csvPokedex)
            {
                try
                {
                    string[] strings = csvPokemon.Split(';');
                    pokedex.Add(new Pokemon(Convert.ToInt16(strings[0]), strings[1], strings[2], Convert.ToBoolean(strings[3])));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Felder der Eingabedatei Pokemon haben das falsche Format");
                    return new MyList<Pokemon>();
                }
                catch (MyInvalidIdException e)
                {
                    Console.WriteLine("Eine ID der Eingabedatei Pokemon ist kleiner als 0");
                    return new MyList<Pokemon>();
                }
            }
            return pokedex;
        }

        public static MyQueue<Digimon> generateDigiedexFromExcel(String path)
        {
            MyQueue<Digimon> digidex = new MyQueue<Digimon>();
            string[] csvDigiedex = { };
            try
            {
                csvDigiedex = File.ReadAllLines(path);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Eingabedatei Digimon kann nicht gefunden werden");
                return new MyQueue<Digimon>();
            }

            foreach (string csvDigimon in csvDigiedex)
            {
                try
                {
                    string[] strings = csvDigimon.Split(';');
                    digidex.Enqueue(new Digimon(Convert.ToInt16(strings[0]), strings[1], Convert.ToInt16(strings[2])));
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Felder der Eingabedatei Digimon haben das falsche Format");
                    return new MyQueue<Digimon>();
                }
                catch (MyInvalidIdException e)
                {
                    Console.WriteLine("Eine ID der Eingabedatei Digimon ist kleiner als 0");
                    return new MyQueue<Digimon>();
                }
            }
            return digidex;
        }
    }
}
