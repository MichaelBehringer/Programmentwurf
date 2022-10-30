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

        //Constructor for Digimon
        //input -  id: integer, name: string, health: integer
        //output - digimon: Digimon
        public Digimon(int id, string name, int health)
        {
            if (id < 0 || id > 999)
            {
                throw new MyInvalidIdException("ID has to be greater than 0 and lower than 999");
            }
            Id = id;
            Name = name;
            Health = health;
        }

        public override string ToString()
        {
            return "Digimon - " + Id.ToString("000") + " - " + Name + " " + Health;
        }
    }
}
