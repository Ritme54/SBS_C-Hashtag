using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Item
    {
        private string name;

        private int Strength;
        private int Agility;
        private int Intelligence;

        public string Name { get { return name; } }

        public int strength { set { strength = value; } }

        public int agility { set { agility = value; } }

        public int intelligence { set { intelligence = value; } }


        public Item(string name, int strength, int agility, int intelligence)
        {
            this.name = name;
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;
        }
    }
}
