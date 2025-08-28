using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Incentive
    {
        public void Enchant(Item item)
        {
            if (item.Name=="Sword")
            {
                item.strength = 10;
            }
            else if (item.Name == "Necklace")
            {
                item.intelligence = 10;

            }
            else if (item.Name == "Shoes")
            {
                item.agility = 10;

            }

        }


    }
}
