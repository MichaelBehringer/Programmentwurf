using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Pokemon : MyIdentify
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Legendary { get; set; }

        public Pokemon(int id, string name, string type, bool legendary)
        {
            if(id<0)
            {
                throw new MyInvalidIdException("ID has to be greater than 0");
            }
            Id = id;
            Name = name;
            Type = type;
            Legendary = legendary;
        }

        public string ToCsv()
        {
            return Id + ";" + Name + ";" + Type + ";" + Legendary;
        }

        public override string ToString() 
        {
            return "Pokemon - " + Id.ToString("000") + " - " + Name + " " + Type + ": " + (Legendary ? "Ja" : "Nein");
        }
    }
}
