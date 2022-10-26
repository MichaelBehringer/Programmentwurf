using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Digimon : MyIdentify
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }

        public Digimon(int id, string name, int health)
        {
            Id = id;
            Name = name;
            Health = health;
        }

        public string ToCsv()
        {
            return Id + ";" + Name + ";" + Health;
        }

        public override string ToString()
        {
            return "Digimon - " + Id.ToString("000") + " - " + Name + " " + Health;
        }
    }
}
