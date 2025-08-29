using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Item
    {
        protected string name;

        protected int Strength;
        protected int Agility;
        protected int Intelligence;

        public string Name { get { return name; } }

        public int strength 
        {
            get { return Strength; }
            set { Strength = value; } 
        }

        public int agility 
        {
            get { return Agility; }
            set { Agility = value; } 
        }

        public int intelligence 
        {
            get { return Intelligence; }    
            set { Intelligence = value; }
        }


        public Item(string name, int strength, int agility, int intelligence)
        {
            this.name = name;
            this.Strength = strength;
            this.Agility = agility;
            this.Intelligence = intelligence;
        }
    }
}
