using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Program
{
    internal class Trader : Entity, TradeIT
    {
        public override string Name => "Food Trader";

        public void Deal()
        {
            Console.WriteLine("Shop open");
        }
    }
    
}
