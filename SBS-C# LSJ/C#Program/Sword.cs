using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Sword : Item, InterfaceUp
    {
        public Sword() : base("Sword", 10, 0, 0)
        { 
        Console.WriteLine("Name : "+ name);
            Console.WriteLine("Strength : " + strength);
            Console.WriteLine("Agility : " + agility);
            Console.WriteLine("Intelligence : " + intelligence);



        }
        public void Upgrade()
        {   
            strength += 5;

            Console.WriteLine("Enchanced Strength : " + strength);
        }
    }

}











